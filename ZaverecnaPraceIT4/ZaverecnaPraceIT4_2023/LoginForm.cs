using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZaverecnaPraceIT4_2023
{
    public partial class LoginForm : Form
    {
        SqlRepository sql = new SqlRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var user = sql.LoginUser(txtUserName.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text))
                {
                    if (user.Role == "Admin")
                    {
                        MenuForm admin = new MenuForm(user);
                        admin.Show();
                        this.Hide();
                        return;
                    }
                    else if (user.Role == "User") ;
                    {
                        UserForm userF = new UserForm(user);
                        userF.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Username or password incorrect.");
        }
    }
}
