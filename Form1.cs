namespace csPOS_System_Management
{
    public partial class frmStart : Form
    {
        frmAdministrator FormAdministrator = new frmAdministrator();
        frmEmployee FormEmployee = new frmEmployee();

        public frmStart()
        {
            InitializeComponent();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {

        }
        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            FormAdministrator.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee.ShowDialog();
        }
    }

}
