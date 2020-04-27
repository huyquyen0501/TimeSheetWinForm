using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetWinForm.Entites;
using TimeSheetWinForm.Utils;

namespace TimeSheetWinForm
{
    public partial class ManageMyTimesheet : Form
    {
        public ManageMyTimesheet()
        {
            InitializeComponent();

        }
        #region
        TimeSheetModel Timesheetmodel = new TimeSheetModel();
        MyTimesheet Mytimeshet = new MyTimesheet();
        //xử lý projectname
        public static List<long> idproject { get; set; }
        public class nameproject
        {
            public long idq { get; set; }
            public string namepr { get; set; }
        }
        List<nameproject> listproject = new List<nameproject>();
        //xử lý projecttask
        public static List<long> idtask { get; set; }
        public class nametask
        {
            public long Idtask { get; set; }
            public string Nametask { get; set; }
        }
        List<nametask> listtask = new List<nametask>();
        #endregion
        void loaddata()
        {
            dgvmytimesheet.DataSource = Timesheetmodel.MyTimesheets.Where(s => s.UserId == Session.UserSessionId).Select(p => new
            {
                ID = p.Id,
                ProjectTaskId = p.ProjectTaskId,
                UserId = p.UserId,
                TypeOfWork = (StatusEnum.TypeOfWork)p.TypeOfWork,
                IsCharged = p.IsCharged,
                Note = p.Note,
                Status = (StatusEnum.TimesheetStatus)p.Status,
                DateAt = p.DateAt,
                WorkingTime = p.WorkingTime
            }).ToList();
        }

        void loadcomboboxprojectname()
        {
            idproject = Timesheetmodel.ProjectUsers.Where(s => s.UserId == Session.UserSessionId).Select(s => s.ProjectId).ToList();//Lấy danh sách id mà user có trong dự án.

            foreach (long a in idproject)
            {
                var name = Timesheetmodel.Projects.Where(s => s.Id == a).Select(s => s.Name).FirstOrDefault();

                listproject.Add(new nameproject()
                {
                    idq = a,
                    namepr = name
                });
            }
            cbprojectname.DataSource = listproject;
            cbprojectname.ValueMember = "idq";
            cbprojectname.DisplayMember = "namepr";

        }
        void comboboxtypeofwork()
        {
            cbtypeofwork.DataSource = Enum.GetValues(typeof(StatusEnum.TypeOfWork));
        }

        private void cbprojectname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbprojectname.SelectedValue.ToString().Count() > 4)//load luc dau no khong nhan duoc idproject
            {

            }
            else
            {
                //cbxtaskname.ResetText();
                for (int i = 0; i < listtask.Count(); i++)
                {
                    listtask.RemoveAt(i);
                }
                var a = long.Parse(cbprojectname.SelectedValue.ToString());
                idtask = Timesheetmodel.ProjectTasks.Where(s => s.ProjectId == a).Select(s => s.TaskId).ToList();
                if (idtask.Count() == 0)
                {
                    cbxtaskname.DataSource = null;
                    MessageBox.Show("The project has no duties yet");
                    btnadd.Enabled = false;
                }
                else
                {
                    foreach (var id in idtask)
                    {
                        var name = Timesheetmodel.Tasks.Where(s => s.Id == id).Select(s => s.Name).FirstOrDefault();

                        listtask.Add(new nametask()
                        {
                            Idtask = id,
                            Nametask = name
                        });
                    }

                    cbxtaskname.DataSource = listtask;
                    cbxtaskname.ValueMember = "Idtask";
                    cbxtaskname.DisplayMember = "Nametask";
                    btnadd.Enabled = true;
                }

            }

        }

        private void ManageMyTimesheet_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcomboboxprojectname();
            comboboxtypeofwork();
            checkischarged.Enabled = false;
        }

        private void cbtypeofwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbprojectname.SelectedValue.ToString().Count() < 4)
            {
                var a = long.Parse(cbprojectname.SelectedValue.ToString());
                var b = long.Parse(cbxtaskname.SelectedValue.ToString());
                var d = cbtypeofwork.SelectedItem.ToString();
                //var id = long.Parse(dgvmytimesheet.SelectedCells[0].OwningRow.Cells["ProjectTaskId"].Value.ToString());
                var id = Timesheetmodel.ProjectTasks.Where(s => s.ProjectId == a && s.TaskId == b).Select(s => s.Id).FirstOrDefault();
                bool typeprotask = Timesheetmodel.ProjectTasks.Where(s => s.Id == id).Select(s => s.Billable).FirstOrDefault();
                if (typeprotask == true && d.CompareTo("OverTime") == 0)
                {
                    checkischarged.Enabled = true;
                }
                else
                {
                    checkischarged.Enabled = false;
                }
            }


        }

        private void dgvmytimesheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvmytimesheet.CurrentRow.Index;
            long idtask = long.Parse(dgvmytimesheet.Rows[i].Cells[1].Value.ToString());

            var idproject1 = Timesheetmodel.ProjectTasks.Where(s => s.Id == idtask).Select(s => s.ProjectId).FirstOrDefault();
            cbprojectname.Text = Timesheetmodel.Projects.Where(s => s.Id == idproject1).Select(s => s.Name).FirstOrDefault();

            var idtask1 = Timesheetmodel.ProjectTasks.Where(s => s.Id == idtask).Select(s => s.TaskId).FirstOrDefault();
            cbxtaskname.Text = Timesheetmodel.Tasks.Where(s => s.Id == idtask1).Select(s => s.Name).FirstOrDefault();

            cbtypeofwork.Text = dgvmytimesheet.Rows[i].Cells[3].Value.ToString();

            if (dgvmytimesheet.Rows[i].Cells[4].Value.ToString().Equals(true))
            {
                checkischarged.Checked = true;
            }
            else
            {
                checkischarged.Checked = false;
            }
            dtdateat.Text = dgvmytimesheet.Rows[i].Cells[7].Value.ToString();
            txtworkingtime.Text = dgvmytimesheet.Rows[i].Cells[8].Value.ToString();
            txtnote.Text = dgvmytimesheet.Rows[i].Cells[6].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtworkingtime.Text != null)
                {
                    var dateat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                    if (Timesheetmodel.MyTimesheets.Any(s => s.UserId == Session.UserSessionId && s.DateAt == dateat))
                    {
                        MessageBox.Show("Today you have taken attendance");
                    }
                    else
                    {
                        var idproject = long.Parse(cbprojectname.SelectedValue.ToString());
                        long idtask = long.Parse(cbxtaskname.SelectedValue.ToString());
                        Mytimeshet.ProjectTaskId = Timesheetmodel.ProjectTasks.Where(s => s.ProjectId == idproject && s.TaskId == idtask).Select(s => s.Id).FirstOrDefault();
                        Mytimeshet.UserId = Session.UserSessionId;
                        int workingtime = int.Parse(txtworkingtime.Text);
                        var typeofword = cbtypeofwork.SelectedItem.ToString();
                        switch (typeofword)
                        {
                            case "NormalWorkingHours":
                                Mytimeshet.TypeOfWork = StatusEnum.TypeOfWork.NormalWorkingHours;
                                if(workingtime > 0 && workingtime <= 8)
                                    Mytimeshet.WorkingTime = workingtime;
                                else
                                {
                                    MessageBox.Show("Time does not satisfy (0;8]");
                                }
                                break;
                            case "OverTime":
                                Mytimeshet.TypeOfWork = StatusEnum.TypeOfWork.OverTime;
                                if (workingtime > 8 && workingtime <= 12)
                                    Mytimeshet.WorkingTime = workingtime;
                                else
                                {
                                    MessageBox.Show("Time does not satisfy (8;12]");
                                }
                                break;
                        }
                        Mytimeshet.IsCharged = checkischarged.Checked;
                        Mytimeshet.Note = txtnote.Text;
                        Mytimeshet.Status = StatusEnum.TimesheetStatus.None;
                        
                        //if(workingtime > 0 )
                       // Mytimeshet.WorkingTime = 
                        Mytimeshet.DateAt = dateat;
                        Timesheetmodel.MyTimesheets.Add(Mytimeshet);
                        Timesheetmodel.SaveChanges();
                        MessageBox.Show("Sign Up Success");
                        loaddata();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the number of hours worked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            var status = Timesheetmodel.MyTimesheets.Where(s => s.UserId == Session.UserSessionId && s.Status == StatusEnum.TimesheetStatus.None).Select(s => s.Id).ToList();
            foreach (var a in status)
            {
                MyTimesheet status1 = Timesheetmodel.MyTimesheets.Where(s => s.Id == a).FirstOrDefault();
                status1.Status = StatusEnum.TimesheetStatus.Approve;
                Timesheetmodel.SaveChanges();
            }
            MessageBox.Show("Sent to Project Manager");
            loaddata();

        }
    }
}
