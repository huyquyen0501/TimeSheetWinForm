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
        //xử lý projectname
        public static List<long> idproject { get; set; }
        public class nameproject{
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
            dgvmytimesheet.DataSource = Timesheetmodel.MyTimesheets.Where(s => s.UserId == Session.UserSessionId).Select(p => new {
                ID = p.Id,
                ProjectTaskId = p.ProjectTaskId,
                UserId = p.UserId,
                TypeOfWork = (StatusEnum.TypeOfWork)p.TypeOfWork,
                IsCharged = p.IsCharged,
                Note = p.Note,
                Status = (StatusEnum.TimesheetStatus)p.Status,
                DateAt = p.DateAt,
                WorkingTime = p.WorkingTime }).ToList();
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
            if(cbprojectname.SelectedValue.ToString().Count() > 4)//load luc dau no khong nhan duoc idproject
            {

            }
            else
            {
                var a = long.Parse(cbprojectname.SelectedValue.ToString());


                idtask = Timesheetmodel.ProjectTasks.Where(s => s.ProjectId == a).Select(s => s.TaskId).ToList();

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
            if(cbprojectname.SelectedValue.ToString().Count() < 4)
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
            }
            
            
        }
    }
}
