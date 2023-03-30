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
        public AddWork()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtWorkName.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in the missing informations");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into WorkType (WorkTypeName, WorkTypeDescription) values ('" + txtWorkName.Text + "','" + txtDescription.Text + "')", con);
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
            txtWorkName.Text = "";
            txtDescription.Text = "";
        }
    }
}
