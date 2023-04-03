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

namespace ZaverecnaPraceIT4_2023
{
    public partial class UserForm : Form
    {
        string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public UserForm(User user)
        {
            con = new SqlConnection(path);
            InitializeComponent();
            displayWork();
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            AddWork aw = new AddWork();
            aw.Show();
        }
        public void displayWork()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("SELECT * FROM WorkType", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
