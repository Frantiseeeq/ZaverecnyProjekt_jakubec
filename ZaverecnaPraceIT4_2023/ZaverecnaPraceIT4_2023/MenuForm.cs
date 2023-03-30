namespace ZaverecnaPraceIT4_2023
{
    public partial class MenuForm : Form
    {
        AddEmployee ae = new AddEmployee();
        AddWork aw = new AddWork();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            ae.Show();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            aw.Show();
        }
    }
}