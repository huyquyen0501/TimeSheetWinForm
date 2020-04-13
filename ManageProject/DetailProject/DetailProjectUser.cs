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

namespace TimeSheetWinForm.ManageProject.DetailProject
{
    public partial class DetailProjectUser : Form
    {
        public DetailProjectUser()
        {
            InitializeComponent();
        }
        #region
        public static List<ProjectUser> projectUsers = new List<ProjectUser>();//chuyen di
        BindingList<User> ListCombobox1Source = new BindingList<User>();//dung cho combobox1
        BindingList<ProjectUserDto> ListDataGridViewSource = new BindingList<ProjectUserDto>();//datagridview
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        List<string> Combobox2Source = new List<string> { "PM", "Member" };
        void LoadData()
        {
            dataGridView1.DataSource = ListDataGridViewSource;
        }
        void loadcombobox()
        {
            try
            {
                comboBox1.DataSource = ListCombobox1Source;
                comboBox1.DisplayMember = "UserName";
                comboBox1.Invalidate();
                comboBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        private void DetailProjectUser_Load(object sender, EventArgs e)
        {
            var list = TimeSheetModel.ProjectUsers.Where(s => s.ProjectId == ManagerProject.ProjectId)
            .Select(s => new ProjectUserDto
            {
                UserId = s.UserId,
                UserName = s.User.UserName,
                Type = s.Type == 0 ? "Member" : "PM",
                ProjectId = s.ProjectId
            }).ToList();
            foreach (var a in list)
            {
                ListDataGridViewSource.Add(a);
            }
            LoadData();
            var a1 = ListDataGridViewSource.Select(t => t.UserId).ToList();
            var listcombobox1 = TimeSheetModel.User.Where(s => a1.Contains(s.Id) == false).ToList();
            foreach (var a in listcombobox1)
            {
                User user = new User();
                user.UserName = a.UserName;
                user.Id = a.Id;
                ListCombobox1Source.Add(user);
            }
            if (ListDataGridViewSource.Count() > 0)
            {
                comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = Combobox2Source;
            comboBox2.DataSource = bs;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = ListCombobox1Source;
            comboBox1.DisplayMember = "UserName";
            comboBox1.Invalidate();
            comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ListDataGridViewSource.Any(s => s.UserName == comboBox1.Text))
                {
                    var pu = new ProjectUserDto
                    {
                        ProjectId = ManagerProject.ProjectId,
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
                    LoadData();
                    loadcombobox();
                }
                else { MessageBox.Show($"Nhân viên {comboBox1.Text} đã có trong dự án"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    var userid = long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (!TimeSheetModel.MyTimesheets.Any(s => s.UserId == userid && s.ProjectTask.ProjectId == ManagerProject.ProjectId))
                    {

                        var tempedObject = ListDataGridViewSource.Where(s => s.UserId == long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())).Select(s => s).FirstOrDefault();
                        foreach (var a in ListDataGridViewSource.ToList())
                        {
                            if (a == tempedObject) { ListDataGridViewSource.Remove(a); }
                        }

                        User task = new User
                        {
                            Id = tempedObject.UserId,
                            UserName = tempedObject.UserName
                        };
                        ListCombobox1Source.Add(task);
                        LoadData();
                        loadcombobox();
                    }
                    else
                    {
                        MessageBox.Show($"User {comboBox1.Text} had logged timesheet, can't delete");
                    }
                }
                else
                {
                    MessageBox.Show("Dự án cần ít nhất 1 thành viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"không thể xóa dòng không có thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value = comboBox2.Text;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value != null)
                {
                    comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Dòng không có thông tin");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dự án cần ít nhất 1 người");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListDataGridViewSource.Any(s => s.Type == "PM"))
                {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
        }
    }
}
