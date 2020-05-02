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
    public partial class ManagerTimesheet : Form
    {
        public ManagerTimesheet()
        {
            InitializeComponent();
            //loaddata(StatusEnum.TimesheetStatus.Pending);
            loadcombobox();
        }
        #region
        TimeSheetModel Timesheetmodel = new TimeSheetModel();
        MyTimesheet Mytimeshet = new MyTimesheet();
        public class timesheet
        {
            public DayOfWeek dayofweek { get; set; }
            public DateTime dateat { get; set; }
            public long projecttaskid { get; set; }
            public String username { get; set; }
            public String TypeOfWork { get; set; }
            public bool IsCharged { get; set; }
            public int WorkingTime { get; set; }
            public String note { get; set; }
            public String Status { get; set; }

        }

        public List<timesheet> dataa = new List<timesheet>();

        public List<string> cbb = new List<string> { "Pending", "Approve", "Reject" };
        #endregion
        void loaddata(StatusEnum.TimesheetStatus e)
        {
            var list = Timesheetmodel.MyTimesheets.Where(s => s.Status == e).Select(p => new
            {
                //ID = p.Id,
                ProjectTaskId = p.ProjectTaskId,
                UserId = p.UserId,
                TypeOfWork = (StatusEnum.TypeOfWork)p.TypeOfWork,
                IsCharged = p.IsCharged,
                Note = p.Note,
                Status = (StatusEnum.TimesheetStatus)p.Status,
                DateAt = p.DateAt,
                WorkingTime = p.WorkingTime
            }).ToList();

            dgvtimesheet.DataSource = list.OrderBy(x => x.DateAt).ToList();
        }

        void loadcombobox()
        {
            //cbbstatus.DataSource = Enum.GetValues(typeof(StatusEnum.TimesheetStatus));
            cbbstatus.DataSource = cbb;
        }

        private void ManagerTimesheet_Load(object sender, EventArgs e)
        {
            //var list = Timesheetmodel.MyTimesheets.Where(s => s.Status == StatusEnum.TimesheetStatus.Reject).Select(p => new
            //{
            //    //ID = p.Id,
            //    ProjectTaskId = p.ProjectTaskId,
            //    UserId = Timesheetmodel.User.Where(s => s.Id == p.UserId).Select(s => s.UserName).FirstOrDefault(),
            //    TypeOfWork = (StatusEnum.TypeOfWork)p.TypeOfWork,
            //    IsCharged = p.IsCharged,
            //    Note = p.Note,
            //    Status = (StatusEnum.TimesheetStatus)p.Status,
            //    DateAt = p.DateAt,
            //    WorkingTime = p.WorkingTime
            //}).ToList();

            //foreach (var a in list)
            //{
            //    timesheet r = new timesheet();
            //    r.dayofweek = a.DateAt.DayOfWeek;
            //    r.dateat = a.DateAt;
            //    r.projecttaskid = a.ProjectTaskId;
            //    r.username = a.UserId;
            //    r.TypeOfWork = a.TypeOfWork.ToString();
            //    r.IsCharged = a.IsCharged;
            //    r.WorkingTime = a.WorkingTime;
            //    r.note = a.Note;
            //    r.Status = a.Status.ToString();

            //    dataa.Add(r);
            //}
            //BindingSource bs =new  BindingSource();
            //bs.DataSource = dataa.OrderBy(x => x.dateat).ToList();
            //dgvtimesheet.DataSource = bs;
            //dgvtimesheet.DataSource = dataa.OrderBy(x => x.dateat).ToList();
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            var timesheetUserProject =  Timesheetmodel.MyTimesheets.Where(s => s.Status == StatusEnum.TimesheetStatus.Pending).ToList();
            foreach (var item in timesheetUserProject)
            {
                MyTimesheet status = item;
                status.Status = StatusEnum.TimesheetStatus.Approve;
                Timesheetmodel.SaveChanges();
            }
            MessageBox.Show("Sent ");
            loaddata(StatusEnum.TimesheetStatus.Approve);
            //ManagerTimesheet_Load(sender, e);

        }

        private void btnreject_Click(object sender, EventArgs e)
        {
            var timesheetUserProject = Timesheetmodel.MyTimesheets.Where(s => s.Status == StatusEnum.TimesheetStatus.Approve).ToList();
            foreach (var item in timesheetUserProject)
            {
                MyTimesheet status = item;
                status.Status = StatusEnum.TimesheetStatus.Reject;
                Timesheetmodel.SaveChanges();
            }
            MessageBox.Show("Sent");
            loaddata(StatusEnum.TimesheetStatus.Reject);
        }

        private void cbbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var status = cbbstatus.SelectedItem.ToString();

            switch (status)
            {
                case "Pending": loaddata(StatusEnum.TimesheetStatus.Pending);
                                break;
                case "Approve": loaddata(StatusEnum.TimesheetStatus.Approve);
                                break;
                case "Reject": loaddata(StatusEnum.TimesheetStatus.Reject);
                                break;
            }

        }
    }
}
