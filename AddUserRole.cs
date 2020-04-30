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
        #endregion

        private void AddUserRole_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcombobox();
        }
        void loaddata()
        {
            var id = int.Parse(lbid.Text);
            dgvuserrole.DataSource = TimeSheetModel.UserRole.Where(s => s.UserId == id).Select(s => s).ToList();
        }

        void loadcombobox()
        {
            var id = int.Parse(lbid.Text);
            //var listr = TimeSheetModel.UserRole.Where(s => s.UserId == id).Select(s => s.RoleId).ToList();

          
            var list = TimeSheetModel.Role.Select(s => new { s.Id, s.RoleName }).ToList();
            cbbrole.DataSource = list;
            cbbrole.DisplayMember = "RoleName";
            cbbrole.ValueMember = "Id";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var iduser = int.Parse(lbid.Text);
            var idrole = int.Parse(cbbrole.SelectedValue.ToString());
            if (TimeSheetModel.UserRole.Any(s => s.Id == iduser && s.RoleId != idrole))
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
    }
}
