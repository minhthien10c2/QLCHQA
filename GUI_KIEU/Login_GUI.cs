using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_KIEU;
using BUS_KIEU;

namespace GUI_KIEU
{
    public partial class Login_GUI : Form
    {
        public Login_GUI()
        {
            InitializeComponent();
        }

        Account_BUS account_bus = new Account_BUS();
        Main main;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                Account_DTO account_dto = new Account_DTO(txtUserName.Text, txtPassword.Text, "", "", "", 0, "");
                DataTable tb = account_bus.CheckAccount(account_dto);
                if (tb.Rows.Count > 0)
                {
                    main = new Main();
                    main.auth = tb.Rows[0].Field<String>("auth");
                    main.account = tb.Rows[0].Field<String>("user_name");
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    main.Show();                  
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            else
            {
                MessageBox.Show("Để đăng nhập bạn cần phải nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    Account_DTO account_dto = new Account_DTO(txtUserName.Text, txtPassword.Text, "", "", "", 0, "");
                    DataTable tb = account_bus.CheckAccount(account_dto);
                    if (tb.Rows.Count > 0)
                    {
                        main = new Main();
                        main.auth = tb.Rows[0].Field<String>("auth");
                        main.account = tb.Rows[0].Field<String>("user_name");
                        MessageBox.Show("Đăng nhập thành công");
                        this.Hide();
                        main.Show();
                        
                    }
                    else
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                else
                {
                    MessageBox.Show("Để đăng nhập bạn cần phải nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    Account_DTO account_dto = new Account_DTO(txtUserName.Text, txtPassword.Text, "", "", "", 0, "");
                    DataTable tb = account_bus.CheckAccount(account_dto);
                    if (tb.Rows.Count > 0)
                    {
                        main = new Main();
                        main.auth = tb.Rows[0].Field<String>("auth");
                        main.account = tb.Rows[0].Field<String>("user_name");
                        MessageBox.Show("Đăng nhập thành công");
                        this.Hide();
                        main.Show();                      
                    }
                    else
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                else
                {
                    MessageBox.Show("Để đăng nhập bạn cần phải nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
