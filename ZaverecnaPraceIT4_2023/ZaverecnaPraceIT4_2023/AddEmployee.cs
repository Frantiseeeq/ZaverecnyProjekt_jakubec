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
    public partial class AddEmployee : Form
    {
        string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand cmd;
        public AddEmployee()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtLastName.Text =="" || txtEmail.Text == "" || TxtPhone.Text=="")
            {
                MessageBox.Show("Please fill in the missing informations");
            }
            else 
            {
                try
                {
                    string admin;
                    if (cbtnAdmin.Checked)
                    {
                        admin = "Admin";
                    }
                    else
                    {
                        admin = "User";
                    }
                    con.Open();
                    cmd = new SqlCommand("insert into Employee (Employee_FirstName, Employee_LastName, Employee_Email, Employee_PhoneNumber, Employee_Role) values ('" + txtName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + TxtPhone.Text + "', '" + admin + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been saved");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void clear()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            TxtPhone.Text = "";
        }
    }
}
