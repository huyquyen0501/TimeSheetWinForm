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

namespace TimeSheetWinForm
{
    public partial class ManageClient : Form
    {
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        #endregion
        public ManageClient()
        {
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {

            dgvKhachhang.DataSource = TimeSheetModel.Customers.Select(s => s).ToList();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txthoten.ResetText();
            txtDiaChi.ResetText();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvKhachhang.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            string name = txthoten.Text; //dgvKhachhang.SelectedCells[0].OwningRow.Cells["Tên_Khách_Hàng"].Value.ToString();
            string address = txtDiaChi.Text; //dgvKhachhang.SelectedCells[0].OwningRow.Cells["Địa_chỉ"].Value.ToString();

            DialogResult result = MessageBox.Show("Do you want to change it?", "Messagebox", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Customer edit = TimeSheetModel.Customers.Where(p => p.Id == id).FirstOrDefault();
                edit.Name = name;
                edit.Address = address;
                TimeSheetModel.SaveChanges();
                loaddata();
            }

        }
        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachhang.CurrentRow.Index;
            txthoten.Text = dgvKhachhang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachhang.Rows[i].Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            try
            {
                if (txthoten.Text != null || txtDiaChi.Text != null)
                {
                    customer.Name = txthoten.Text;
                    customer.Address = txtDiaChi.Text;
                    customer.IsDeleted = false;
                    TimeSheetModel.Customers.Add(customer);
                    TimeSheetModel.SaveChanges();
                    MessageBox.Show("Add success");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Please enter enough information");
                    txthoten.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error in adding process");
            }
        }
    }
}
