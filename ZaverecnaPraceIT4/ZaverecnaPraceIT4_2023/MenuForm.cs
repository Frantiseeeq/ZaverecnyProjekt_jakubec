using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ZaverecnaPraceIT4_2023
{
    public partial class MenuForm : Form
    {
        string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        
       
        public MenuForm(User user)
        {
            con = new SqlConnection(path);
            InitializeComponent();
            displayUsers();
            displayEmployees();
            displayWork();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            AddWork aw = new AddWork();
            aw.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {        
            AddUser au = new AddUser();
            au.Show();
        }
        public void displayUsers()
        {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT User_ID, User_Name, User_Role FROM UsersLogin", con);
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
        }
        public void displayEmployees()
        {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM EMPLOYEE", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
        }
        public void displayWork()
        { 
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM WorkType", con);
                adpt.Fill(dt);
                dataGridView3.DataSource = dt;
                con.Close();
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}