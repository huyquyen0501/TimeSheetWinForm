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
using TimeSheetWinForm.ManageProject.Dto;

namespace TimeSheetWinForm.ManageProject
{
    public partial class AddUser : Form
    {
        #region static va cac ham
        public static List<ProjectUser> projectUsers = new List<ProjectUser>();//chuyen di
         BindingList<User> ListCombobox1Source = new BindingList<User>();//dung cho combobox1
        BindingList<ProjectUserDto> ListDataGridViewSource = new BindingList<ProjectUserDto>();//datagridview
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        List<string> Combobox2Source = new List<string> { "PM", "Member" };
        void LoadData()
        {
            dataGridView1.DataSource = ListDataGridViewSource;
        }
        #endregion
        public AddUser()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListDataGridViewSource.Any(s=>s.Type=="PM")) {
                    
                    foreach (var a in ListDataGridViewSource)
                    {
                        ProjectUser pt = new ProjectUser();
                        pt.ProjectId = AddNewProject.ProjectID;
                        pt.UserId = a.UserId;
                        pt.Type = a.Type == "PM" ? ProjectUserType.PM : ProjectUserType.Billable;
                        projectUsers.Add(pt);
                    }

                    this.Close();
                }
                else { MessageBox.Show("Dự án cần ít nhất 1 PM, vui lòng chỉnh sửa lại"); }
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            LoadData();
            var list = TimeSheetModel.User.ToList();
            
            foreach(var a in list)
            {
                
                ListCombobox1Source.Add(a);
            }
            comboBox1.DataSource = ListCombobox1Source;
            comboBox1.DisplayMember = "UserName";
            comboBox1.Invalidate();
            BindingSource bs = new BindingSource();
            bs.DataSource = Combobox2Source;
            comboBox2.DataSource = bs;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            comboBox1.DataSource = ListCombobox1Source;
            comboBox1.DisplayMember = "UserName";
            comboBox1.Invalidate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            /*BindingSource bs = new BindingSource();
            bs.DataSource = ProjectUserTypes;
            comboBox2.DataSource = bs;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var ab = TimeSheetModel.User.Where(s => s.Name == comboBox1.Text).Select(s => new { UserId=s.Id,Name= s.Name }).ToList();
            if (!String.IsNullOrEmpty(ListCombobox1Source.Select(s => s.Name).FirstOrDefault()))
            {
                var pu = new ProjectUserDto
                {
                    ProjectId = AddNewProject.ProjectID,
                    Type = comboBox2.Text,
                    UserName = comboBox1.Text,
                    UserId = ListCombobox1Source.Where(s => s.UserName == comboBox1.Text).Select(s => s.Id).FirstOrDefault()
                };
                ListDataGridViewSource.Add(pu);
                foreach (var a in ListCombobox1Source.ToList())
                {
                    if (a.Id == pu.UserId)
                    {
                        ListCombobox1Source.Remove(a);
                        break;
                    }
                }
            }
            else { MessageBox.Show("Da het thanh vien de tham gia du an"); }
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var tempedObject = ListDataGridViewSource.Where(s => s.UserId == long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString())).Select(s => s).FirstOrDefault();
                foreach (var a in ListDataGridViewSource.ToList())
                {
                    if (a == tempedObject) { ListDataGridViewSource.Remove(a); }
                }

                User task = new User
                {
                    Id = tempedObject.UserId,
                    Name = tempedObject.UserName
                };
                ListCombobox1Source.Add(task);
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"không thể xóa dòng không có thông tin");
            }
        }
    }
}
