namespace csPOS_System_Management
{
    partial class frmAdministrator
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            panel2 = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            linkForgotPassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.icons8_admin_50_black;
            pictureBox1.Location = new Point(5, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(152, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 37);
            panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(5, 11);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(77, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(148, 23);
            txtUsername.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(152, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 37);
            panel2.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(5, 11);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password  :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(152, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(287, 128);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(293, 104);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(95, 15);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            // 
            // frmAdministrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 178);
            ControlBox = false;
            Controls.Add(linkForgotPassword);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAdministrator";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtUsername;
        private Label lblUsername;
        private Panel panel2;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private LinkLabel linkForgotPassword;
    }
}