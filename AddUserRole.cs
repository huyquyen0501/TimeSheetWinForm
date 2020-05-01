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
    public partial class AddUserRole : Form
    {
        
        public AddUserRole(long id)
        {
            InitializeComponent();
            lbid.Text = id.ToString();
        }

        #region
        TimeSheetModel TimeSheetModel = new TimeSheetModel();
        UserRole userrole = new UserRole();
        public class listdata
        {
            public string username { get; set; }
            public string namerole { get; set; }
        }
        List<listdata> dataa = new List<listdata>();
        #endregion

        private void AddUserRole_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcombobox();
        }
        void loaddata()
        {

            var id = int.Parse(lbid.Text);
            var list = TimeSheetModel.UserRole.Where(s => s.UserId == id && s.IsDeleted != true).Select(s => new
            {   
                ID = s.Id,
                username = TimeSheetModel.User.Where(p => p.Id == s.UserId).Select(p => p.UserName).FirstOrDefault(),
                name = TimeSheetModel.Role.Where(p => p.Id == s.RoleId).Select(p => p.RoleName).FirstOrDefault()
            }).ToList();
            dgvuserrole.DataSource = list;
        }

        void loadcombobox()
        {
            var id = int.Parse(lbid.Text);
            var list = TimeSheetModel.Role.Select(s => new { s.Id, s.RoleName }).ToList();
           
            cbbrole.DataSource = list;
            cbbrole.DisplayMember = "RoleName";
            cbbrole.ValueMember = "Id";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var iduser = int.Parse(lbid.Text);
            var idrole = int.Parse(cbbrole.SelectedValue.ToString());
            if (TimeSheetModel.UserRole.Any(s => s.UserId == iduser && s.RoleId == idrole && s.IsDeleted != true) == false)
            {
                userrole.UserId = iduser;
                userrole.RoleId = idrole;
                TimeSheetModel.UserRole.Add(userrole);
                TimeSheetModel.SaveChanges();
                MessageBox.Show("Success");
                loaddata();
            }
            else
            {
                MessageBox.Show("role already exists");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var index =int.Parse(dgvuserrole.Rows[dgvuserrole.CurrentRow.Index].Cells[0].Value.ToString());
            UserRole delete = TimeSheetModel.UserRole.Where(p => p.Id == index).FirstOrDefault();
            delete.IsDeleted = true;
            TimeSheetModel.SaveChanges();
            loaddata();
        }
    }
}
