namespace csPOS_System_Management
{
    partial class frmEmployee
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
            panel1 = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            linkForgotPassword = new LinkLabel();
            btnExit = new Button();
            btnLogin = new Button();
            linkSIgnUp = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(152, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 37);
            panel1.TabIndex = 7;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.icons8_user_50_black;
            pictureBox1.Location = new Point(5, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(152, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 37);
            panel2.TabIndex = 8;
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
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(293, 104);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(95, 15);
            linkForgotPassword.TabIndex = 11;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(287, 128);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(152, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // linkSIgnUp
            // 
            linkSIgnUp.AutoSize = true;
            linkSIgnUp.Location = new Point(150, 104);
            linkSIgnUp.Name = "linkSIgnUp";
            linkSIgnUp.Size = new Size(48, 15);
            linkSIgnUp.TabIndex = 12;
            linkSIgnUp.TabStop = true;
            linkSIgnUp.Text = "Sign Up";
            linkSIgnUp.LinkClicked += linkSIgnUp_LinkClicked;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 178);
            ControlBox = false;
            Controls.Add(linkSIgnUp);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(linkForgotPassword);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblPassword;
        private TextBox txtPassword;
        private LinkLabel linkForgotPassword;
        private Button btnExit;
        private Button btnLogin;
        private LinkLabel linkSIgnUp;
    }
}