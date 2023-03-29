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
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Enter your username aand password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginUsers where User_Name = @Name and User_Pwd = @Pwd", con);
                    cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Pwd", txtPassword.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("You have succesfully Logged In");
                        MenuForm mf = new MenuForm();
                        mf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check your username aand password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //SqlConnection con = new SqlConnection();
        }
    }
}
