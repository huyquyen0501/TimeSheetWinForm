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
            //dgvKhachhang.DataSource = from u in TimeSheetModel.Customers
            //                          select new
            //                          {
            //                              ID = u.Id,
            //                              Tên_Khách_Hàng = u.Name,
            //                              Địa_Chỉ = u.Address
            //                          };

            dgvKhachhang.DataSource = TimeSheetModel.Customers.Select(s => new
            {
                ID = s.Id,
                Tên_Khách_Hàng = s.Name,
                Địa_chỉ = s.Address
            }).ToList();     
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txthoten.ResetText();
            txtDiaChi.ResetText();
            Customer customer = new Customer();

            try
            {
                if(txthoten.Text == null || txtDiaChi.Text == null)
                {
                    customer.Name = txthoten.Text;
                    customer.Address = txtDiaChi.Text;

                    TimeSheetModel.Customers.Add(customer);
                    TimeSheetModel.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình thêm");
            }
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachhang.CurrentRow.Index;
            txthoten.Text = dgvKhachhang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachhang.Rows[i].Cells[2].Value.ToString();
        }
    }
}
