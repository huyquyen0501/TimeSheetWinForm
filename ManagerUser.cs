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
    public partial class ManagerUser : Form
    {
        public ManagerUser()
        {
            InitializeComponent();
            loaddata();
            btnmk.Enabled = false;
            foreach (var a in Session.RoleNameOfUser)
            {
                if (a.Equals("Admin"))
                    btnmk.Enabled = true; 
            }
        }
        #region
        TimeSheetModel TimeSheetModel = new TimeSheetModel();
        #endregion
        void loaddata()
        {
            dgvuser.DataSource = TimeSheetModel.User.Select(p=> new {p.Id, p.SurName, p.Name, p.UserName,p.DateOfBirth, p.Address}).ToList();
            

        }

        private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvuser.CurrentRow.Index;
            txtid.Text = dgvuser.Rows[i].Cells[0].Value.ToString();
            txtho.Text = dgvuser.Rows[i].Cells[1].Value.ToString();
            txtten.Text = dgvuser.Rows[i].Cells[2].Value.ToString();
            txtusername.Text = dgvuser.Rows[i].Cells[3].Value.ToString();
            dateNgaysinh.Text = dgvuser.Rows[i].Cells[4].Value.ToString();
            txtDiachi.Text = dgvuser.Rows[i].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());
            string surname = dgvuser.SelectedCells[0].OwningRow.Cells["SurName"].Value.ToString();
            string name = dgvuser.SelectedCells[0].OwningRow.Cells["Name"].Value.ToString();
            string birth = dgvuser.SelectedCells[0].OwningRow.Cells["DateOfBirth"].Value.ToString();
            string address = dgvuser.SelectedCells[0].OwningRow.Cells["Address"].Value.ToString();

            User edit = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
            edit.SurName = surname;
            edit.Name = name;
            edit.DateOfBirth =DateTime.Parse(birth);
            edit.Address = address;

            TimeSheetModel.SaveChanges();
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());
            //var list = TimeSheetModel.ProjectUsers.Where(s =>s.ProjectId== )
            /*var strin = from a in TimeSheetModel.ProjectUsers
                        from b in TimeSheetModel.Projects
                        where a.ProjectId == b.Id
                        select new { a.UserId, b.Id, b.TimeStart, b.TimeEnd };*/

                var query = TimeSheetModel.ProjectUsers.Where(s => s.UserId == id).Select(s=>s.ProjectId);
          //  if ()
          //  {
                
         //   }
            User delete = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
            TimeSheetModel.User.Remove(delete);
            TimeSheetModel.SaveChanges();
            loaddata();
        }

        private void btnmk_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());

            User edit = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
            edit.PassWord = BCrypt.Net.BCrypt.HashPassword("1");

            TimeSheetModel.SaveChanges();
            MessageBox.Show("Đã cập nhập mật khẩu mặc định là '1'");
            loaddata();
        }
    }
}
