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
            dgvuser.DataSource = TimeSheetModel.User.Where(p=>p.IsDeleted !=true).
                Select(p => new { p.Id, p.SurName, p.Name, p.UserName, p.DateOfBirth, p.Address }).ToList();
        }

        void checkdata()
        {
            
            
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
            DateTime d1 = DateTime.Now;
            if(d1.Year - dateNgaysinh.Value.Year > 18)
            {
                var id = long.Parse(txtid.Text);
                string surname = txtho.Text;
                string name =txtten.Text;
                string birth =dateNgaysinh.Text;
                string address = txtDiachi.Text;

                User edit = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
                edit.SurName = surname;
                edit.Name = name;
                edit.DateOfBirth = DateTime.Parse(birth);
                edit.Address = address;

                TimeSheetModel.SaveChanges();
                loaddata();
            }
            else
            {
                MessageBox.Show("Employees must be over 18 years old");
                dateNgaysinh.Focus();
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());

            if (!TimeSheetModel.MyTimesheets.Any(s => s.UserId == id))
            {
                //Xoas duoc
                User delete = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
                delete.IsDeleted = true;
                TimeSheetModel.SaveChanges();
                loaddata();
            }
            else
            {
                MessageBox.Show("Can not delete");
            }
        }

        private void btnmk_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());

            User edit = TimeSheetModel.User.Where(p => p.Id == id).FirstOrDefault();
            edit.PassWord = BCrypt.Net.BCrypt.HashPassword("1");

            TimeSheetModel.SaveChanges();
            MessageBox.Show("Password has changed to '1'");
            loaddata();
        }  

        private void btnrole_Click(object sender, EventArgs e)
        {
            var id = long.Parse(dgvuser.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());
            AddUserRole frm = new AddUserRole(id);
            frm.ShowDialog();
        }
    }
}
