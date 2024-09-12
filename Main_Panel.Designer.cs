namespace csPOS_System_Management
{
    partial class frmMainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDashboard = new Button();
            btnRevenue = new Button();
            pnlDropdown = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnMembersManagement = new Button();
            btnTrainersManagement = new Button();
            btnClassSchedules = new Button();
            btnAttendanceTracking = new Button();
            btnMemberships = new Button();
            btnBillingPayments = new Button();
            tmrDropdown = new System.Windows.Forms.Timer(components);
            tmrSidecut = new System.Windows.Forms.Timer(components);
            pnlSide = new FlowLayoutPanel();
            pnlTrainersManagement = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            tmrWelcome = new System.Windows.Forms.Timer(components);
            pnlWelcome = new Panel();
            btnWelcome = new Button();
            btnLogout = new Button();
            btnChangePassword = new Button();
            btnProfile = new Button();
            btnNotifications = new Button();
            pnlTopside = new Panel();
            btnMenu = new Button();
            pictureBox3 = new PictureBox();
            pnlTop = new Panel();
            panel1 = new Panel();
            pnlShowHere = new Panel();
            pnlNotifications = new Panel();
            panel4 = new Panel();
            lblNotifications = new Label();
            panel2 = new Panel();
            tmrDropdownTM = new System.Windows.Forms.Timer(components);
            tmrNotifications = new System.Windows.Forms.Timer(components);
            pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSide.SuspendLayout();
            pnlTrainersManagement.SuspendLayout();
            pnlWelcome.SuspendLayout();
            pnlTopside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTop.SuspendLayout();
            panel1.SuspendLayout();
            pnlNotifications.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.icons8_stocks_23;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(203, 39);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = Color.Black;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnRevenue.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Image = Properties.Resources.icons8_revenue_23;
            btnRevenue.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevenue.Location = new Point(3, 48);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(203, 39);
            btnRevenue.TabIndex = 3;
            btnRevenue.Text = "Revenue";
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // pnlDropdown
            // 
            pnlDropdown.Controls.Add(button3);
            pnlDropdown.Controls.Add(button2);
            pnlDropdown.Controls.Add(button1);
            pnlDropdown.Controls.Add(pictureBox1);
            pnlDropdown.Controls.Add(btnMembersManagement);
            pnlDropdown.Location = new Point(3, 93);
            pnlDropdown.MaximumSize = new Size(203, 159);
            pnlDropdown.MinimumSize = new Size(203, 39);
            pnlDropdown.Name = "pnlDropdown";
            pnlDropdown.Size = new Size(203, 39);
            pnlDropdown.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8.25F);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 117);
            button3.Name = "button3";
            button3.Size = new Size(203, 39);
            button3.TabIndex = 15;
            button3.Text = "   Update Member";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F);
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 78);
            button2.Name = "button2";
            button2.Size = new Size(203, 39);
            button2.TabIndex = 14;
            button2.Text = "   Delete Member";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 39);
            button1.Name = "button1";
            button1.Size = new Size(203, 39);
            button1.TabIndex = 13;
            button1.Text = "   Add Member";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.icons8_management_24__1_;
            pictureBox1.Location = new Point(6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnMembersManagement
            // 
            btnMembersManagement.BackColor = Color.Black;
            btnMembersManagement.Dock = DockStyle.Top;
            btnMembersManagement.FlatAppearance.BorderSize = 0;
            btnMembersManagement.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnMembersManagement.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnMembersManagement.FlatStyle = FlatStyle.Flat;
            btnMembersManagement.Image = Properties.Resources.icons8_expand_arrow_152;
            btnMembersManagement.ImageAlign = ContentAlignment.MiddleRight;
            btnMembersManagement.Location = new Point(0, 0);
            btnMembersManagement.Name = "btnMembersManagement";
            btnMembersManagement.Size = new Size(203, 39);
            btnMembersManagement.TabIndex = 4;
            btnMembersManagement.Text = "      Members Management";
            btnMembersManagement.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMembersManagement.UseVisualStyleBackColor = false;
            btnMembersManagement.Click += btnMembersManagement_Click_1;
            // 
            // btnTrainersManagement
            // 
            btnTrainersManagement.BackColor = Color.Black;
            btnTrainersManagement.Dock = DockStyle.Top;
            btnTrainersManagement.FlatAppearance.BorderSize = 0;
            btnTrainersManagement.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnTrainersManagement.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnTrainersManagement.FlatStyle = FlatStyle.Flat;
            btnTrainersManagement.Image = Properties.Resources.icons8_expand_arrow_15;
            btnTrainersManagement.ImageAlign = ContentAlignment.MiddleRight;
            btnTrainersManagement.Location = new Point(0, 0);
            btnTrainersManagement.Name = "btnTrainersManagement";
            btnTrainersManagement.Size = new Size(203, 39);
            btnTrainersManagement.TabIndex = 6;
            btnTrainersManagement.Text = "Trainers Management";
            btnTrainersManagement.UseVisualStyleBackColor = false;
            btnTrainersManagement.Click += btnTrainersManagement_Click;
            // 
            // btnClassSchedules
            // 
            btnClassSchedules.BackColor = Color.Black;
            btnClassSchedules.FlatAppearance.BorderSize = 0;
            btnClassSchedules.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnClassSchedules.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnClassSchedules.FlatStyle = FlatStyle.Flat;
            btnClassSchedules.Image = Properties.Resources.icons8_schedule_24;
            btnClassSchedules.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassSchedules.Location = new Point(3, 183);
            btnClassSchedules.Name = "btnClassSchedules";
            btnClassSchedules.Size = new Size(203, 39);
            btnClassSchedules.TabIndex = 5;
            btnClassSchedules.Text = "Classes && Schedules";
            btnClassSchedules.UseVisualStyleBackColor = false;
            btnClassSchedules.Click += btnClassSchedules_Click;
            // 
            // btnAttendanceTracking
            // 
            btnAttendanceTracking.BackColor = Color.Black;
            btnAttendanceTracking.FlatAppearance.BorderSize = 0;
            btnAttendanceTracking.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnAttendanceTracking.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnAttendanceTracking.FlatStyle = FlatStyle.Flat;
            btnAttendanceTracking.Image = Properties.Resources.icons8_attendance_24;
            btnAttendanceTracking.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendanceTracking.Location = new Point(3, 228);
            btnAttendanceTracking.Name = "btnAttendanceTracking";
            btnAttendanceTracking.Size = new Size(203, 39);
            btnAttendanceTracking.TabIndex = 7;
            btnAttendanceTracking.Text = "Attendance Tracking";
            btnAttendanceTracking.UseVisualStyleBackColor = false;
            btnAttendanceTracking.Click += btnAttendanceTracking_Click;
            // 
            // btnMemberships
            // 
            btnMemberships.BackColor = Color.Black;
            btnMemberships.FlatAppearance.BorderSize = 0;
            btnMemberships.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnMemberships.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnMemberships.FlatStyle = FlatStyle.Flat;
            btnMemberships.Image = Properties.Resources.icons8_diamond_24;
            btnMemberships.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemberships.Location = new Point(3, 318);
            btnMemberships.Name = "btnMemberships";
            btnMemberships.Size = new Size(203, 39);
            btnMemberships.TabIndex = 11;
            btnMemberships.Text = "Memberships";
            btnMemberships.UseVisualStyleBackColor = false;
            btnMemberships.Click += btnMemberships_Click;
            // 
            // btnBillingPayments
            // 
            btnBillingPayments.BackColor = Color.Black;
            btnBillingPayments.FlatAppearance.BorderSize = 0;
            btnBillingPayments.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnBillingPayments.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnBillingPayments.FlatStyle = FlatStyle.Flat;
            btnBillingPayments.Image = Properties.Resources.icons8_peso_23;
            btnBillingPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnBillingPayments.Location = new Point(3, 273);
            btnBillingPayments.Name = "btnBillingPayments";
            btnBillingPayments.Size = new Size(203, 39);
            btnBillingPayments.TabIndex = 8;
            btnBillingPayments.Text = "Billing && Payments";
            btnBillingPayments.UseVisualStyleBackColor = false;
            btnBillingPayments.Click += btnBillingPayments_Click;
            // 
            // tmrDropdown
            // 
            tmrDropdown.Interval = 15;
            tmrDropdown.Tick += tmrDropdown_Tick;
            // 
            // tmrSidecut
            // 
            tmrSidecut.Interval = 5;
            tmrSidecut.Tick += tmrSidecut_Tick;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.Black;
            pnlSide.Controls.Add(btnDashboard);
            pnlSide.Controls.Add(btnRevenue);
            pnlSide.Controls.Add(pnlDropdown);
            pnlSide.Controls.Add(pnlTrainersManagement);
            pnlSide.Controls.Add(btnClassSchedules);
            pnlSide.Controls.Add(btnAttendanceTracking);
            pnlSide.Controls.Add(btnBillingPayments);
            pnlSide.Controls.Add(btnMemberships);
            pnlSide.Location = new Point(0, 54);
            pnlSide.MaximumSize = new Size(220, 674);
            pnlSide.MinimumSize = new Size(43, 674);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(220, 674);
            pnlSide.TabIndex = 14;
            // 
            // pnlTrainersManagement
            // 
            pnlTrainersManagement.Controls.Add(button6);
            pnlTrainersManagement.Controls.Add(button5);
            pnlTrainersManagement.Controls.Add(button4);
            pnlTrainersManagement.Controls.Add(btnTrainersManagement);
            pnlTrainersManagement.Location = new Point(3, 138);
            pnlTrainersManagement.MaximumSize = new Size(203, 155);
            pnlTrainersManagement.MinimumSize = new Size(203, 39);
            pnlTrainersManagement.Name = "pnlTrainersManagement";
            pnlTrainersManagement.Size = new Size(203, 39);
            pnlTrainersManagement.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Navy;
            button6.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.icons8_expand_arrow_15;
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(0, 117);
            button6.Name = "button6";
            button6.Size = new Size(203, 39);
            button6.TabIndex = 9;
            button6.Text = "Trainers Management";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Navy;
            button5.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.icons8_expand_arrow_15;
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(0, 78);
            button5.Name = "button5";
            button5.Size = new Size(203, 39);
            button5.TabIndex = 8;
            button5.Text = "Trainers Management";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Navy;
            button4.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.icons8_expand_arrow_15;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 39);
            button4.Name = "button4";
            button4.Size = new Size(203, 39);
            button4.TabIndex = 7;
            button4.Text = "Trainers Management";
            button4.UseVisualStyleBackColor = false;
            // 
            // tmrWelcome
            // 
            tmrWelcome.Interval = 15;
            tmrWelcome.Tick += tmrWelcome_Tick;
            // 
            // pnlWelcome
            // 
            pnlWelcome.Controls.Add(btnWelcome);
            pnlWelcome.Controls.Add(btnLogout);
            pnlWelcome.Controls.Add(btnChangePassword);
            pnlWelcome.Controls.Add(btnProfile);
            pnlWelcome.Location = new Point(1218, 11);
            pnlWelcome.MaximumSize = new Size(140, 175);
            pnlWelcome.MinimumSize = new Size(140, 43);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(140, 43);
            pnlWelcome.TabIndex = 15;
            // 
            // btnWelcome
            // 
            btnWelcome.BackColor = Color.DarkBlue;
            btnWelcome.Dock = DockStyle.Top;
            btnWelcome.FlatAppearance.BorderSize = 0;
            btnWelcome.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnWelcome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnWelcome.FlatStyle = FlatStyle.Flat;
            btnWelcome.Image = Properties.Resources.icons8_user_30;
            btnWelcome.ImageAlign = ContentAlignment.MiddleRight;
            btnWelcome.Location = new Point(0, 0);
            btnWelcome.MinimumSize = new Size(140, 43);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(140, 43);
            btnWelcome.TabIndex = 3;
            btnWelcome.Text = "Welcome | Admin";
            btnWelcome.TextAlign = ContentAlignment.MiddleLeft;
            btnWelcome.UseVisualStyleBackColor = false;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.WhiteSmoke;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogout.Image = Properties.Resources.icons8_logout_24;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 132);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 43);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.WhiteSmoke;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnChangePassword.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.ForeColor = Color.FromArgb(64, 64, 64);
            btnChangePassword.Image = Properties.Resources.icons8_settings_24__1_;
            btnChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.Location = new Point(0, 89);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(140, 43);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "        Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.WhiteSmoke;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.FromArgb(64, 64, 64);
            btnProfile.Image = Properties.Resources.people_16551886;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 45);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(140, 43);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.DarkBlue;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNotifications.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Image = Properties.Resources.icons8_bell_24;
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(860, 13);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(135, 37);
            btnNotifications.TabIndex = 9;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // pnlTopside
            // 
            pnlTopside.BackColor = Color.MediumBlue;
            pnlTopside.Controls.Add(btnMenu);
            pnlTopside.Controls.Add(pictureBox3);
            pnlTopside.Location = new Point(0, 0);
            pnlTopside.Name = "pnlTopside";
            pnlTopside.Size = new Size(220, 54);
            pnlTopside.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Image = Properties.Resources.option;
            btnMenu.Location = new Point(5, 15);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 31);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = Properties.Resources.cy_removebg_preview;
            pictureBox3.Location = new Point(46, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(pnlTopside);
            pnlTop.Controls.Add(pnlWelcome);
            pnlTop.Controls.Add(panel1);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1370, 729);
            pnlTop.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlShowHere);
            panel1.Controls.Add(pnlNotifications);
            panel1.Controls.Add(btnNotifications);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(220, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 728);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint_2;
            // 
            // pnlShowHere
            // 
            pnlShowHere.AutoScroll = true;
            pnlShowHere.BackColor = Color.White;
            pnlShowHere.Location = new Point(0, 53);
            pnlShowHere.Name = "pnlShowHere";
            pnlShowHere.Size = new Size(1150, 675);
            pnlShowHere.TabIndex = 11;
            // 
            // pnlNotifications
            // 
            pnlNotifications.BackColor = Color.WhiteSmoke;
            pnlNotifications.Controls.Add(panel4);
            pnlNotifications.Location = new Point(783, 55);
            pnlNotifications.MaximumSize = new Size(305, 404);
            pnlNotifications.MinimumSize = new Size(305, 10);
            pnlNotifications.Name = "pnlNotifications";
            pnlNotifications.Size = new Size(305, 10);
            pnlNotifications.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(lblNotifications);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 35);
            panel4.TabIndex = 0;
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotifications.ForeColor = Color.Black;
            lblNotifications.Location = new Point(14, 4);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(123, 25);
            lblNotifications.TabIndex = 0;
            lblNotifications.Text = "Notifications";
            lblNotifications.Click += lblNotifications_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(-8, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1158, 54);
            panel2.TabIndex = 10;
            // 
            // tmrDropdownTM
            // 
            tmrDropdownTM.Interval = 15;
            tmrDropdownTM.Tick += tmrDropdownTM_Tick;
            // 
            // tmrNotifications
            // 
            tmrNotifications.Interval = 1;
            tmrNotifications.Tick += tmrNotifications_Tick;
            // 
            // frmMainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 729);
            Controls.Add(pnlSide);
            Controls.Add(pnlTop);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainPanel";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dgfdfggfh";
            WindowState = FormWindowState.Maximized;
            Load += frmMainPanel_Load;
            pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSide.ResumeLayout(false);
            pnlTrainersManagement.ResumeLayout(false);
            pnlWelcome.ResumeLayout(false);
            pnlTopside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlNotifications.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClassSchedules;
        private Button btnBillingPayments;
        private Button btnAttendanceTracking;
        private Button btnTrainersManagement;
        private Button btnMemberships;
        private System.Windows.Forms.Timer tmrDropdown;
        private Button btnRevenue;
        private Button btnDashboard;
        private Panel pnlDropdown;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnMembersManagement;
        private System.Windows.Forms.Timer tmrSidecut;
        private FlowLayoutPanel pnlSide;
        private System.Windows.Forms.Timer tmrWelcome;
        private Panel pnlWelcome;
        private Button btnWelcome;
        private Button btnLogout;
        private Button btnChangePassword;
        private Button btnProfile;
        private Button btnNotifications;
        private Panel pnlTopside;
        private Button btnMenu;
        private PictureBox pictureBox3;
        private Panel pnlTop;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlTrainersManagement;
        private Button button6;
        private Button button5;
        private Button button4;
        private System.Windows.Forms.Timer tmrDropdownTM;
        private Panel pnlShowHere;
        private Panel pnlNotifications;
        private Panel panel4;
        private System.Windows.Forms.Timer tmrNotifications;
        private Label lblNotifications;
    }
}