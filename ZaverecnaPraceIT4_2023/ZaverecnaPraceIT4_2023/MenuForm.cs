namespace ZaverecnaPraceIT4_2023
{
    public partial class MenuForm : Form
    {
        AddEmployee ae = new AddEmployee();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            ae.Show();  
        }
    }
}