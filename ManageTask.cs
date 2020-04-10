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

namespace TimeSheetWinForm
{
    public partial class ManageTask : Form
    {
        public ManageTask()
        {
            InitializeComponent();
        }
        #region
        TimeSheetModel Timesheetmodel = new TimeSheetModel();

        #endregion
        private void ManageTask_Load(object sender, EventArgs e)
        {
            dgvtask.DataSource = Timesheetmodel.Tasks.Where(s => s.IsDeleted != true).Select(s => new
            {
                ID = s.Id,
                Name = s.Name,
                TypeTask = (StatusEnum.TaskType)s.Type
            }).ToList();

            loadcombobox();
        }

        void loadcombobox()
        {
            //StatusEnum.TaskType d = new StatusEnum.TaskType();
            cbxtype.DataSource = Enum.GetValues(typeof(StatusEnum.TaskType));

            //int d = int.Parse(cbxtype.SelectedValue.ToString());
            //cbxtype.DisplayMember = d;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            Entites.Task task = new Entites.Task();
            var d = cbxtype.SelectedItem.ToString();
            var s = cbxtype.SelectedIndex;
            //string s = "StatusEnum.TaskType." + d;

            //StatusEnum.TaskType b = (int)s;
            Array allenum = Enum.GetValues(typeof(StatusEnum.TaskType));//lấy ra tất cả các phần tử enum
           
            try
            {
                if(txtname.Text != null)
                {
                    task.Name = txtname.Text;
                    //task.Type = 
                }
            }
            catch
            {

            }
            

        }
    }
}
