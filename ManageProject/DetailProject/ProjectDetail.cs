using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheetWinForm.ManageProject.DetailProject
{
    public partial class ProjectDetail : Form
    {
        public ProjectDetail()
        {
            InitializeComponent();
        }
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        
        #endregion
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProjectDetail_Load(object sender, EventArgs e)
        {
            var a = TimeSheetModel.Projects.Where(s => s.Id == ManagerProject.ProjectId).FirstOrDefault();
            label9.Text = a.Id.ToString();
            textBox1.Text = a.Name;
            textBox2.Text = a.Code;
            dateTimePicker1.Value = a.TimeStart;
            dateTimePicker2.Value = a.TimeEnd;
            comboBox1.DataSource = TimeSheetModel.Customers.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.Invalidate();
            comboBox1.Text = a.Customer.Name;
            richTextBox1.Text = a.Note;
            textBox1.ReadOnly=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailProjectUser detailProjectUser = new DetailProjectUser();
            detailProjectUser.Show();
        }
    }
}
