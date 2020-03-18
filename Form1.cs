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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        
        public bool CheckPassWord(string PassWordUnHash, string Hashed)
        {
            return BCrypt.Net.BCrypt.Verify(PassWordUnHash, Hashed);
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            var UserName = textBox1.Text;
            var password = textBox2.Text;
            if(UserName ==null || password == null)
            {
                MessageBox.Show("Nhap vao username va mat khau", "Loi");
            }
            var a = TimeSheetModel.User.Where(s => s.UserName == UserName).Select(s => new
            {
                UserName = s.UserName,
                //Role = s.Roles.RoleName,
                UserId = s.Id,
                password=s.PassWord,
                Name=s.Name
            }).ToList();
            if(a.Any())
            {
               
                if (CheckPassWord(password, a.First().password))
                {
                    Session.UserSessionId = a.First().UserId;
                    Session.Name = a.First().UserName;
                    Session.RoleNameOfUser  = TimeSheetModel.UserRole.Where(s => s.UserId == Session.UserSessionId).Select(s => s.Roles.RoleName).ToList();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau", "Error");
                }
            }
            else { MessageBox.Show("Sai ten dang nhap hoac mat khau", "Error"); }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox2.PasswordChar = '@';
        }
    }
}
