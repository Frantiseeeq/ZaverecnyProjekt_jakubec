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
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public AddEmployee()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
                    if (rbtnAdmin.Checked)
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
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            TxtPhone.Text = "";
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM EMPLOYEE", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            rbtnAdmin.Checked = true;
            rbtnUser.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()=="User")
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

                if(rbtnAdmin.Checked)
                {
                    admin = "Admin";
                }
                else
                {
                    admin = "User";
                }

                con.Open();
                cmd = new SqlCommand("update employee set Employee_FirstName = '" + txtName.Text + "', Employee_LastName = '" + txtLastName.Text + "', Employee_Email = '" + txtEmail.Text + "', Employee_PhoneNumber = '" + TxtPhone.Text + "', Employee_Role = '" + admin + "' where Employee_Id = '"+ ID +"' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your data has been updated");
                display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from employee where Employee_Id = '" + ID + "'", con);
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
