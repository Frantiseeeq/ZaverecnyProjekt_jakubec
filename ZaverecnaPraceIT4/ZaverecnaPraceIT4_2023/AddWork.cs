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
    public partial class AddWork : Form
    {
        string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int ID;
        public AddWork()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtWorkName.Text == "" || txtWorkDescription.Text == "")
            {
                MessageBox.Show("Please fill in the missing informations");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into WorkType (WorkTypeName, WorkTypeDescription) values ('" + txtWorkName.Text + "','" + txtWorkDescription.Text + "')", con);
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
            txtWorkName.Text = "";
            txtWorkDescription.Text = "";
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM WorkType", con);
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
            txtWorkName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtWorkDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from WorkType where WorkType_ID = '" + ID + "'", con);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update WorkType set WorkTypeName = '" + txtWorkName.Text + "', WorkTypeDescription = '" + txtWorkDescription.Text + "'where WorkType_ID = '"+ ID +"'", con);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}