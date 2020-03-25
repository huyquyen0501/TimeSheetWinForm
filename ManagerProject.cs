using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetWinForm.ManageProject;
using TimeSheetWinForm.Utils;

namespace TimeSheetWinForm
{
    public partial class ManagerProject : Form
    {
        public ManagerProject()
        {
            InitializeComponent();
        }
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        void Loaddata()
        {
            var projectShowed = TimeSheetModel.ProjectUsers
                .Where(s => Session.RoleNameOfUser.Contains("Admin") || Session.RoleNameOfUser.Contains("ProjectAdmin") || s.UserId == Session.UserSessionId)
                .Select(s => s.ProjectId);
            dataGridView1.DataSource = TimeSheetModel.Projects.Where(s => projectShowed.Contains(s.Id))
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Code,
                    CustomerName = s.Customer.Name,
                    s.Status,
                    s.TimeStart,
                    s.TimeEnd
                }).OrderByDescending(s => s.Id).ToList();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên Project";
            dataGridView1.Columns[2].HeaderText = "Code";
            dataGridView1.Columns[3].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[4].HeaderText = "Trạng thái project";
            dataGridView1.Columns[5].HeaderText = "Thời gian bắt đầu";
            dataGridView1.Columns[6].HeaderText = "Thời gian kết thúc";
        }
        #endregion

        private void ManagerProject_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddNewProject addNewProject = new AddNewProject();
            addNewProject.Show();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
