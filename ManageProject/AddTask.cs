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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            
        }
        #region List&entitytotransfer
         List<Entites.Task> listTaskComboBox = new List<Entites.Task>();
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        public static List<ProjectTaskDto> Temped = new List<ProjectTaskDto>();
         List<string> Billable = new List<string> { "Billable", "Nonbillable" };
       
        
        #endregion
        private void AddTask_Load(object sender, EventArgs e)
        {
            listTaskComboBox = TimeSheetModel.Tasks.ToList();
            
            dataGridView1.DataSource = Temped;
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.DataSource = Billable;
                if (dataGridView1.Rows.Count != 0)
                {
                    comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Billable;
            comboBox2.DataSource = bs;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            /*BindingSource bs = new BindingSource();
            bs.DataSource = listTaskComboBox;*/
            
            comboBox1.DataSource = listTaskComboBox;
            
            comboBox1.ValueMember = "Name";
            comboBox1.Invalidate();
            if (dataGridView1.Rows.Count != 0)
            {
                comboBox1.Text = $"{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}|{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()}";
            }

            label4.Text = listTaskComboBox.Where(s => s.Name == comboBox1.Text).Select(s => s.Id).FirstOrDefault().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectTaskDto pt = new ProjectTaskDto
                {
                    ProjectId = AddNewProject.ProjectID,
                    TaskId = long.Parse(label4.Text),
                    TaskName = comboBox1.Text,
                    Billable = comboBox2.Text

                };
                Temped.Add(pt);
                listTaskComboBox.RemoveAll(s => s.Name == comboBox1.Text);
                dataGridView1.DataSource = Temped;
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectTaskDto pt = new ProjectTaskDto();
            var tempedObject = Temped.Where(s => s.TaskId == long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString())).Select(s => s).FirstOrDefault();
            Temped.RemoveAll(s => s == tempedObject);
            ProjectTask

            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = $"{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}|{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()}";
        }
    }
}
