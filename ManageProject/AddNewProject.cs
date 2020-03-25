using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            addUser.ProjectId = ProjectID;
            addUser.Show();
        }
        #region ProjectID
        public static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        public static long ProjectID = (TimeSheetModel.Projects.Max(s => s.Id) + 1);
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            
            addTask.Show();
        }
    }
}
