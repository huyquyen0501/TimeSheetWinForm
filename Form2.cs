using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetWinForm.Utils;

namespace TimeSheetWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            //this.IsMdiContainer = true;
        }
        #region
        private static bool _exiting;
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {
          
            label1.Text = $"Xin chào {Session.Name}";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;
            foreach(var a in Session.RoleNameOfUser)
            {
                switch (a)
                {
                    case "Admin":
                        button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = true;
                        break;
                    case "ProjectAdmin":
                         button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = true;
                        break;
                    case "SuperVisor":
                        button2.Enabled = button3.Enabled = button5.Enabled = button8.Enabled = true;
                        break;
                    case "BasicUser":
                        button6.Enabled = true;
                        break;
                        

                }

            }
            //Neu Basicuser nhung duoc lam PM cua du an thi se bat duoc cac nut manage project,managetask, timesheet nhung chi duoc phep xem du an no lam quan ly
            //(xu ly viec hien ra o  cac code cua doan sau nhe, o day chi xu ly viec bat nut)
            if (TimeSheetModel.ProjectUsers.Any(s => s.UserId == Session.UserSessionId && s.Type == ProjectUserType.PM))
            {
                button2.Enabled = button4.Enabled = button5.Enabled = true;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (!_exiting && MessageBox.Show("Bạn có chắc chắn muốn thoát?","Messenger",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                Session.UserSessionId = 0;
                Session.Name = "";
                Session.RoleNameOfUser = null;
                Environment.Exit(1);
            }
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerUser managerUser = new ManagerUser();
            //managerUser.MdiParent = this;
            managerUser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerProject managerProject = new ManagerProject();
            //managerProject.MdiParent = this;
            managerProject.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageClient manageClient = new ManageClient();
            //manageClient.MdiParent = this;
            manageClient.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageTask manageTask = new ManageTask();
            //manageTask.MdiParent = this;
            manageTask.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagerTimesheet managerTimesheet = new ManagerTimesheet();
            //managerTimesheet.MdiParent = this;
            managerTimesheet.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageMyTimesheet manageMyTimesheet = new ManageMyTimesheet();
            //manageMyTimesheet.MdiParent = this;
            manageMyTimesheet.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            //config.MdiParent = this;
            config.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManageTimesheetStatic manageTimesheetStatic = new ManageTimesheetStatic();
           // manageTimesheetStatic.MdiParent = this;
            manageTimesheetStatic.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
