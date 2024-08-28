namespace csPOS_System_Management
{
    public partial class frmStart : Form
    {
        frmAdministrator FormAdmin = new frmAdministrator();

        public frmStart()
        {
            InitializeComponent();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {

        }
        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            FormAdmin.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }
    }

}
