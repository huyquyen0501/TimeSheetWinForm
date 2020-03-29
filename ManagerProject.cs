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
                    s.TimeEnd,
                    s.ProjectType,
                    s.Note
                }).OrderBy(s => s.Id).ToList();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên Project";
            dataGridView1.Columns[2].HeaderText = "Code";
            dataGridView1.Columns[3].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[4].HeaderText = "Trạng thái project";
            dataGridView1.Columns[5].HeaderText = "Thời gian bắt đầu";
            dataGridView1.Columns[6].HeaderText = "Thời gian kết thúc";
            dataGridView1.Columns[7].HeaderText = "Loại Project";
            dataGridView1.Columns[8].HeaderText = "Ghi chú";
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

        private void button7_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var projectid= long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var a = TimeSheetModel.Projects.Where(s => s.Id == projectid);
            a.FirstOrDefault().Status = Entites.StatusEnum.ProjectStatus.Active;
            TimeSheetModel.SaveChanges();
            Loaddata();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var projectid = long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var a = TimeSheetModel.Projects.Where(s => s.Id == projectid);
            a.FirstOrDefault().Status = Entites.StatusEnum.ProjectStatus.Deactive;
            TimeSheetModel.SaveChanges();
            Loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
