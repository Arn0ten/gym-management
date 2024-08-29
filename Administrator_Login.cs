using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csPOS_System_Management
{
    
    public partial class frmAdministrator : Form
    {
        frmMainPanel MainPanel = new frmMainPanel();
        public frmAdministrator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainPanel.ShowDialog();
        }
    }
}
