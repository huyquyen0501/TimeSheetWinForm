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
    public partial class DetailProjectTasks : Form
    {
        public DetailProjectTasks()
        {
            InitializeComponent();
        }
        #region List&entitytotransfer
        BindingList<Entites.Task> listTaskComboBox = new BindingList<Entites.Task>();
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        public BindingList<ProjectTaskDto> Temped = new BindingList<ProjectTaskDto>();
        public static List<ProjectTask> listTaskAdd = new List<ProjectTask>();
        List<string> Billable = new List<string> { "Billable", "Nonbillable" };
        public void loadcombobox()
        {

        }
        public void Loaddata()
        {
            dataGridView1.DataSource = Temped;
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DetailProjectTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
