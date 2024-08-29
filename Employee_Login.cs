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
    public partial class frmEmployee : Form
    {
        frmEmployeeSignUp FormEmployeeSignUp = new frmEmployeeSignUp();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSIgnUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEmployeeSignUp.ShowDialog();
        }
    }
}
