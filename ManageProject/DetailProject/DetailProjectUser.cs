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
        #endregion
        private void DetailProjectUser_Load(object sender, EventArgs e)
        {
            var list = TimeSheetModel.ProjectUsers.Where(s => s.ProjectId == ManagerProject.ProjectId)
            .Select(s=>new ProjectUserDto{ 
            UserId=s.UserId,
            UserName=s.User.UserName,
            Type=s.Type==0?"Member":"PM",
            ProjectId=s.ProjectId
            }).ToList();
            foreach(var a in list)
            {
                ListDataGridViewSource.Add(a);
            }
            LoadData();
            var listcombobox1 = TimeSheetModel.User
            if (ListDataGridViewSource.Count() > 0)
            {
                comboBox1.Text=
            }
        }
    }
}
