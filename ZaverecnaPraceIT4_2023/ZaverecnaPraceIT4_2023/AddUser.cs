using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZaverecnaPraceIT4_2023
{
    public partial class AddUser : Form
    {
        string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;

        public AddUser()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the missing informations");
            }
            else
            {
                try
                {
                    string admin;
                    if (rbtnAdmin.Checked)
                    {
                        admin = "Admin";
                    }
                    else
                    {
                        admin = "User";
                    }
                    con.Open();
                    cmd = new SqlCommand("insert into LoginUsers (User_Name, User_Pwd, User_Role) values ('" + txtUserName.Text + "','" + txtPassword.Text + "', '" + admin + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been saved");
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT User_ID, User_Name, User_Role FROM LoginUsers", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            rbtnAdmin.Checked = true;
            rbtnUser.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "User")
            {
                rbtnAdmin.Checked = false;
                rbtnUser.Checked = true;
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string admin;

                if (rbtnAdmin.Checked)
                {
                    admin = "Admin";
                }
                else
                {
                    admin = "User";
                }

                con.Open();
                cmd = new SqlCommand("update LoginUsers set User_Name = '" + txtUserName.Text + "', User_Pwd = '" + txtPassword.Text + "', User_Role = '" + admin + "' where User_ID = '" + ID + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been updated");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from LoginUsers where User_ID = '" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been deleted");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
