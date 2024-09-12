using csPOS_System_Management.Properties;
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
    public partial class frmMainPanel : Form
    {
        private bool isCollapsed;
        private bool isExpanded = false;
        private bool isCollapsedWelcome;
        private bool isCollapsedTM;
        private bool isCollapsedNotifications;

        public frmMainPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmMainPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnMembersManagement_Click(object sender, EventArgs e)
        {

        }

        private void tmrDropdown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                btnMembersManagement.Image = Resources.icons8_collapse_arrow_15;
                pnlDropdown.Height += 10;
                if (pnlDropdown.Size == pnlDropdown.MaximumSize)
                {
                    tmrDropdown.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnMembersManagement.Image = Resources.icons8_expand_arrow_15;
                pnlDropdown.Height -= 10;
                if (pnlDropdown.Size == pnlDropdown.MinimumSize)
                {
                    tmrDropdown.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnMembersManagement_Click_1(object sender, EventArgs e)
        {

            if (isExpanded)
            {
                return;
            }
            tmrDropdown.Start();
            tmrDropdownTM.Stop();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            tmrSidecut.Start();


            if (!isCollapsed && !isCollapsedTM)
            {

                tmrDropdown.Start();
                tmrDropdownTM.Start();
            }
        }


        private void tmrSidecut_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {

                pnlSide.Width += 10;
                if (pnlSide.Size == pnlSide.MaximumSize)
                {
                    tmrSidecut.Stop();
                    isExpanded = false;
                }
            }
            else
            {

                pnlSide.Width -= 10;
                if (pnlSide.Size == pnlSide.MinimumSize)
                {
                    tmrSidecut.Stop();
                    isExpanded = true;
                }
            }
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            pnlWelcome.BringToFront();
            if (isCollapsedWelcome)
            {
                pnlWelcome.Height += 10;

                if (pnlWelcome.Height >= pnlWelcome.MaximumSize.Height)
                {
                    tmrWelcome.Stop();
                    isCollapsedWelcome = false;
                }
            }
            else
            {
                pnlWelcome.Height -= 10;
                if (pnlWelcome.Height <= pnlWelcome.MinimumSize.Height)
                {
                    tmrWelcome.Stop();
                    isCollapsedWelcome = true;
                }
            }
        }




        private void btnWelcome_Click(object sender, EventArgs e)
        {
            pnlWelcome.BringToFront();
            tmrWelcome.Start();
        }

        private void tmrDropdownTM_Tick(object sender, EventArgs e)
        {
            if (isCollapsedTM)
            {

                btnTrainersManagement.Image = Resources.icons8_collapse_arrow_15;
                pnlTrainersManagement.Height += 10;
                if (pnlTrainersManagement.Size == pnlTrainersManagement.MaximumSize)
                {
                    tmrDropdownTM.Stop();
                    isCollapsedTM = false;
                }
            }
            else
            {
                btnTrainersManagement.Image = Resources.icons8_expand_arrow_15;
                pnlTrainersManagement.Height -= 10;
                if (pnlTrainersManagement.Size == pnlTrainersManagement.MinimumSize)
                {
                    tmrDropdownTM.Stop();
                    isCollapsedTM = true;
                }
            }
        }

        private void btnTrainersManagement_Click(object sender, EventArgs e)
        {
            tmrDropdownTM.Start();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmDashboard dashboard = new frmDashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnClassSchedules_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmClasses_Schedules classSchedules = new frmClasses_Schedules();
            classSchedules.TopLevel = false;
            classSchedules.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(classSchedules);
            classSchedules.Show();
        }


        private void btnRevenue_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmRevenue revenue = new frmRevenue();
            revenue.TopLevel = false;
            revenue.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(revenue);
            revenue.Show();
        }


        private void btnAttendanceTracking_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmAttendanceTracking attendanceTracking = new frmAttendanceTracking();
            attendanceTracking.TopLevel = false;
            attendanceTracking.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(attendanceTracking);
            attendanceTracking.Show();
        }


        private void btnMemberships_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmMemberships memberships = new frmMemberships();
            memberships.TopLevel = false;
            memberships.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(memberships);
            memberships.Show();
        }


        private void btnBillingPayments_Click(object sender, EventArgs e)
        {
            pnlShowHere.Controls.Clear();
            frmBilling_Payments billingPayments = new frmBilling_Payments();
            billingPayments.TopLevel = false;
            billingPayments.Dock = DockStyle.Fill;
            pnlShowHere.Controls.Add(billingPayments);
            billingPayments.Show();
        }

        private void tmrNotifications_Tick(object sender, EventArgs e)
        {

            if (isCollapsedNotifications)
            {


                pnlNotifications.Height += 10;
                if (pnlNotifications.Size == pnlNotifications.MaximumSize)
                {
                    tmrNotifications.Stop();
                    isCollapsedNotifications = false;
                }
            }
            else
            {

                pnlNotifications.Height -= 10;
                if (pnlNotifications.Size == pnlNotifications.MinimumSize)
                {
                    tmrNotifications.Stop();
                    isCollapsedNotifications = true;
                    pnlNotifications.SendToBack();
                }
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            pnlNotifications.BringToFront();
            tmrNotifications.Start();
        }

        private void lblNotifications_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}

