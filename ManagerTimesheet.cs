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
        }
        #region
        TimeSheetModel Timesheetmodel = new TimeSheetModel();
        MyTimesheet Mytimeshet = new MyTimesheet();
        #endregion
        void loaddata()
        {
            dgvtimesheet.DataSource = Timesheetmodel.MyTimesheets.Where(s => s.Status == StatusEnum.TimesheetStatus.Approve).Select(p => new
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
        }
    }
}
