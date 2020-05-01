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
            userToolStripMenuItem.Enabled = false;
            manageProjectsToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            manageTaskToolStripMenuItem.Enabled = false;
            timesheetToolStripMenuItem.Enabled = false;
            myToolStripMenuItem.Enabled = false;
            configToolStripMenuItem.Enabled = true;
            timesheetStaticToolStripMenuItem.Enabled = false;
            foreach(var a in Session.RoleNameOfUser)
            {
                switch (a)
                {
                    case "Admin":
                        userToolStripMenuItem.Enabled = manageProjectsToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = myToolStripMenuItem.Enabled = configToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "ProjectAdmin":
                        manageProjectsToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = myToolStripMenuItem.Enabled = configToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "SuperVisor":
                        manageProjectsToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "BasicUser":
                        myToolStripMenuItem.Enabled = true;
                        break;
                        

                }

            }
            //Neu Basicuser nhung duoc lam PM cua du an thi se bat duoc cac nut manage project,managetask, timesheet nhung chi duoc phep xem du an no lam quan ly
            //(xu ly viec hien ra o  cac code cua doan sau nhe, o day chi xu ly viec bat nut)
            if (TimeSheetModel.ProjectUsers.Any(s => s.UserId == Session.UserSessionId && s.Type == ProjectUserType.PM))
            {
                manageProjectsToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = true;
            }
            
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerUser managerUser = new ManagerUser();
            //managerUser.MdiParent = this;
            managerUser.ShowDialog();
        }

        private void manageProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerProject managerProject = new ManagerProject();
            //managerProject.MdiParent = this;
            managerProject.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClient manageClient = new ManageClient();
            //manageClient.MdiParent = this;
            manageClient.ShowDialog();
        }

        private void manageTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTask manageTask = new ManageTask();
            //manageTask.MdiParent = this;
            manageTask.ShowDialog();
        }

        private void timesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerTimesheet managerTimesheet = new ManagerTimesheet();
            //managerTimesheet.MdiParent = this;
            managerTimesheet.ShowDialog();
        }

        private void myToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMyTimesheet manageMyTimesheet = new ManageMyTimesheet();
            //manageMyTimesheet.MdiParent = this;
            manageMyTimesheet.ShowDialog();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            //config.MdiParent = this;
            config.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Messenger",
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

        private void timesheetStaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTimesheetStatic manageTimesheetStatic = new ManageTimesheetStatic();
            // manageTimesheetStatic.MdiParent = this;
            manageTimesheetStatic.ShowDialog();
        }
    }
}
