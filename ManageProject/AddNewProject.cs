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

namespace TimeSheetWinForm.ManageProject
{
    public partial class AddNewProject : Form
    {
        public AddNewProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            addUser.Show();
            button1.Enabled = false;
        }
        #region ProjectID
        Project project = new Project();
        public static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        public static long ProjectID = (TimeSheetModel.Projects.Max(s => s.Id) + 1);
        List<string> ProjectType = new List<string>
        {
            "TimeAndMaterials",
            "FixedFee",
            "NoneBillable"
        };
        List<Customer> customers = new List<Customer>();
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();

            addTask.Show();
            button2.Enabled = false;
        }

        private void AddNewProject_Load(object sender, EventArgs e)
        {
            customers = TimeSheetModel.Customers.ToList();
            comboBox3.DataSource = customers;
            comboBox3.DisplayMember = "Name";
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ProjectType;
            comboBox2.DataSource = bindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddTask.listTaskAdd != null && AddUser.projectUsers != null)
                {
                    if (dateTimePicker1.Value.AddDays(7) < dateTimePicker2.Value)
                    {
                        if (!TimeSheetModel.Projects.Any(s => s.Name == textBox1.Text))
                        {
                            project.Id = ProjectID;
                            project.Name = textBox1.Text;
                            project.Code = textBox2.Text;
                            project.TimeStart = dateTimePicker1.Value;
                            project.TimeEnd = dateTimePicker2.Value;
                            project.Status = StatusEnum.ProjectStatus.Active;
                            if (comboBox2.Text == "TimeAndMaterials")
                            { project.ProjectType = StatusEnum.ProjectType.TimeAndMaterials; }
                            else if (comboBox2.Text == "FixedFee")
                            {
                                project.ProjectType = StatusEnum.ProjectType.FixedFee;
                            }
                            else { project.ProjectType = StatusEnum.ProjectType.NoneBillable; }
                            project.CustomerId = TimeSheetModel.Customers.Where(s => s.Name == comboBox3.Text).Select(s => s.Id).FirstOrDefault();
                            project.Note = richTextBox1.Text == null ? "  " : richTextBox1.Text;
                            TimeSheetModel.Projects.Add(project);
                            TimeSheetModel.SaveChanges();
                            ProjectID = TimeSheetModel.Projects.Where(s => s.Name == project.Name).Select(s => s.Id).FirstOrDefault();
                            foreach (var a in AddUser.projectUsers)
                            {
                                a.ProjectId = ProjectID;
                            }
                            foreach (var a in AddTask.listTaskAdd)
                            {
                                a.ProjectId = ProjectID;
                            }
                            TimeSheetModel.ProjectUsers.AddRange(AddUser.projectUsers);
                            TimeSheetModel.ProjectTasks.AddRange(AddTask.listTaskAdd);
                            TimeSheetModel.SaveChanges();
                            AddUser.projectUsers.Clear();
                            AddTask.listTaskAdd.Clear();
                            this.Close();
                        }
                        else { MessageBox.Show("Tên project đã tồn tại"); }
                    }
                    else { MessageBox.Show("Thời gian dự án quá ngắn"); }
                }
                else { MessageBox.Show("Project cần thêm thành viên và Tasks"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thêm mới project");
            }
            }
        }
    } 
