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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '@';
            textBox7.PasswordChar = '@';

        }
        #region
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        #endregion
        private void button1_Click(object sender, EventArgs e)
        { User user = new User();
            try
            {
                if (textBox1 != null && textBox2 != null && textBox3 != null &&  textBox5 != null && textBox6 != null && textBox7 != null)
                {
                    if (textBox7.Text == textBox6.Text)
                    {
                        if (TimeSheetModel.User.Any(s => s.UserName == textBox5.Text) == false)
                        {
                            
                            user.Name = textBox1.Text;
                            user.SurName = textBox2.Text;
                            user.Address = textBox3.Text;
                            user.DateOfBirth = dateTimePicker1.Value;
                            user.UserName = textBox5.Text;
                            user.PassWord = BCrypt.Net.BCrypt.HashPassword(textBox6.Text);
                            TimeSheetModel.User.Add(user);
                            TimeSheetModel.SaveChanges();
                            MessageBox.Show("Đăng ký thành công, vui lòng trở lại trang đăng nhập");
                            
                        }
                        else { MessageBox.Show("UserName đã tồn tại"); }
                    }
                    else { MessageBox.Show("Mật khẩu nhập lại không đúng"); }
                }
                else { MessageBox.Show("Vui lòng nhập đủ thông tin"); }
            }catch(Exception ex)
            {
                MessageBox.Show("Loi trong qua trinh dang ky", "Loi");
            }
        }
    }
}
