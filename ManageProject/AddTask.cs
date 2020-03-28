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
        BindingList<Entites.Task> listTaskComboBox = new BindingList<Entites.Task>();
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        public BindingList<ProjectTaskDto> Temped = new BindingList<ProjectTaskDto>();
        public static List<ProjectTask> listTaskAdd = new List<ProjectTask>();
        List<string> Billable = new List<string> { "Billable", "Nonbillable" };
        public void Loaddata()
        {
            dataGridView1.DataSource = Temped;
        }

        #endregion
        private void AddTask_Load(object sender, EventArgs e)
        {
            try
            {
                var list = TimeSheetModel.Tasks.ToList();
                foreach (var a in list)
                {
                    listTaskComboBox.Add(a);
                }

                comboBox2.DataSource = Billable;
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text= listTaskComboBox.Where(s => s.Name == comboBox1.Text).Select(s => s.Id).FirstOrDefault().ToString();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            /*BindingSource bs = new BindingSource();
            bs.DataSource = Billable;
            comboBox2.DataSource = bs;*/
            try {
                if (dataGridView1.Rows.Count > 1)
                {
                    comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            /*BindingSource bs = new BindingSource();
            bs.DataSource = listTaskComboBox;*/
            
            comboBox1.DataSource = listTaskComboBox;
            
            comboBox1.ValueMember = "Name";
            comboBox1.Invalidate();

            //label4.Text = listTaskComboBox.Where(s => s.Name == comboBox1.Text).Select(s => s.Id).FirstOrDefault().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(listTaskComboBox.Select(s => s.Name).FirstOrDefault()))
                {
                    var pt = new ProjectTaskDto
                    {
                        ProjectId = AddNewProject.ProjectID,
                        TaskId =    listTaskComboBox.Where(s=>s.Name==comboBox1.Text).Select(s=>s.Id).FirstOrDefault(),
                        TaskName = comboBox1.Text,
                        Billable = comboBox2.Text

                    };
                    Temped.Add(pt);


                    foreach (var a in listTaskComboBox.ToList())
                    {
                        if (a.Name == pt.TaskName)
                            listTaskComboBox.Remove(a);
                    }
                    dataGridView1.DataSource = Temped;
                }
                else
                {
                    MessageBox.Show("Khong con task de lua chon");
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectTask pt = new ProjectTask();
            foreach (var a in Temped)
            {
                pt.ProjectId = AddNewProject.ProjectID;
                pt.TaskId = a.TaskId;
                pt.Billable = a.Billable == "Billable" ? true : false;
                listTaskAdd.Add(pt);
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectTaskDto pt = new ProjectTaskDto();
            var tempedObject = Temped.Where(s => s.TaskId == long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString())).Select(s => s).FirstOrDefault();
            foreach(var a in Temped.ToList())
            {
                if (a == tempedObject) { Temped.Remove(a); }
            }
            
            Entites.Task task = new Entites.Task
            {
                Id = tempedObject.TaskId,
                Name = tempedObject.TaskName
            };
            listTaskComboBox.Add(task);
            Loaddata();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = $"{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}|{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()}";
        }
    }
}
