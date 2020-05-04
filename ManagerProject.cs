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
using TimeSheetWinForm.ManageProject.DetailProject;
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
            dataGridView1.DataSource = TimeSheetModel.Projects.Where(s => projectShowed.Contains(s.Id) && s.IsDeleted == false)
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
        public static long ProjectId;
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
            long projectId = 0;
            var isValidId = long.TryParse(textBox1.Text, out projectId);
            if (isValidId)
            {
                var project = from p in TimeSheetModel.Projects
                              where p.Id == projectId
                              select p;
                if (project != null)
                    Loaddata();
                else
                    MessageBox.Show("Khong ton tai project");
            }
            else
                MessageBox.Show("Id khong hop le");

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
            bool FormNotOpen=true;
               FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "ProjectDetail")
                {
                    FormNotOpen = false;
                }
            }
            if (FormNotOpen)
            {
                ProjectId = long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ProjectDetail projectDetail = new ProjectDetail();
                projectDetail.Show();
            }
            else
            {
                MessageBox.Show("Form đang chạy, vui lòng đóng lại trước khi mở form mới");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectId = long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var hasTimesheet = TimeSheetModel.MyTimesheets.Any(t => t.ProjectTask.ProjectId == ProjectId);
            if (hasTimesheet)
                MessageBox.Show("Khong the xoa project vi co ton tai timesheet ");
            else
            {
                var projectTask = from pt in TimeSheetModel.ProjectTasks
                                  where pt.ProjectId == ProjectId
                                  select pt;
                foreach (var pt in projectTask)           
                    pt.IsDeleted = true;

                var projectUser = from pu in TimeSheetModel.ProjectUsers
                                  where pu.ProjectId == ProjectId
                                  select pu;
                foreach (var pu in projectUser)
                    pu.IsDeleted = true;
                var project = (from p in TimeSheetModel.Projects
                              where p.Id == ProjectId
                              select p).FirstOrDefault();
                project.IsDeleted = true;
                TimeSheetModel.SaveChanges();
                Loaddata();
            }
        }
    }
}
