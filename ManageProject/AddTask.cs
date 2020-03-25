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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        static List<ProjectTask> Temped = new List<ProjectTask>();
        public long ProjectId { get; set; }
        #endregion
        private void AddTask_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = TimeSheetModel.Tasks.ToList();
            List<string> Billable = new List<string> { "Billable", "Nonbillable" };
            dataGridView1.DataSource = Temped;
       }
    }
}
