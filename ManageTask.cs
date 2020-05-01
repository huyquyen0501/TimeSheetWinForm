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
            cbxtype.DataSource = Enum.GetValues(typeof(StatusEnum.TaskType));
        }
        

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            Entites.Task task = new Entites.Task();
            var d = cbxtype.SelectedItem.ToString();
           
            try
            {
                if (txtname.Text != null)
                {
                    task.Name = txtname.Text;
                    switch (d)
                    {
                        case "CommonTask":
                            task.Type = StatusEnum.TaskType.CommonTask;
                            break;
                        case "OrtherTask":
                            task.Type = StatusEnum.TaskType.OrtherTask;
                            break;
                    }
                    task.IsDeleted = false;
                    Timesheetmodel.Tasks.Add(task);
                    Timesheetmodel.SaveChanges();
                    MessageBox.Show("Sign Up Success");
                    ManageTask_Load(sender, e);
                }
                else
                    MessageBox.Show("Please enter task name");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
            

        }

        private void dgvtask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvtask.CurrentRow.Index;
            txtId.Text = dgvtask.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dgvtask.Rows[i].Cells[1].Value.ToString();
            cbxtype.Text = dgvtask.Rows[i].Cells[2].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var d = cbxtype.SelectedItem.ToString();
            Entites.Task edit = Timesheetmodel.Tasks.Where(s => s.Id == id).FirstOrDefault();
            edit.Name = txtname.Text;
            switch (d)
            {
                case "CommonTask":
                    edit.Type = StatusEnum.TaskType.CommonTask;
                    break;
                case "OrtherTask":
                    edit.Type = StatusEnum.TaskType.OrtherTask;
                    break;
            }
            Timesheetmodel.SaveChanges();
            MessageBox.Show("fix successful");
            ManageTask_Load(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Entites.Task delete = Timesheetmodel.Tasks.Where(s => s.Id == id).FirstOrDefault();

            delete.IsDeleted = true;
            Timesheetmodel.SaveChanges();
            MessageBox.Show("Delete successful");
            ManageTask_Load(sender, e);
        }
    }
}
