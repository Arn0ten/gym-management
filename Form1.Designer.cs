namespace csPOS_System_Management
{
    partial class frmStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdministrator = new Button();
            btnEmployee = new Button();
            SuspendLayout();
            // 
            // btnAdministrator
            // 
            btnAdministrator.Anchor = AnchorStyles.None;
            btnAdministrator.BackColor = Color.Lime;
            btnAdministrator.FlatAppearance.BorderColor = Color.Lime;
            btnAdministrator.FlatAppearance.BorderSize = 0;
            btnAdministrator.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            btnAdministrator.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnAdministrator.FlatStyle = FlatStyle.Popup;
            btnAdministrator.Font = new Font("Arial", 18F, FontStyle.Bold);
            btnAdministrator.ForeColor = Color.White;
            btnAdministrator.Image = Properties.Resources.icons8_admin_settings_male_50;
            btnAdministrator.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministrator.Location = new Point(69, 108);
            btnAdministrator.Name = "btnAdministrator";
            btnAdministrator.Size = new Size(238, 78);
            btnAdministrator.TabIndex = 3;
            btnAdministrator.Text = "Administrator";
            btnAdministrator.TextAlign = ContentAlignment.MiddleRight;
            btnAdministrator.UseVisualStyleBackColor = false;
            btnAdministrator.Click += btnAdministrator_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Anchor = AnchorStyles.None;
            btnEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnEmployee.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.Font = new Font("Arial", 18F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = Properties.Resources.icons8_admin_50;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(329, 108);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(238, 78);
            btnEmployee.TabIndex = 5;
            btnEmployee.Text = "       Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 317);
            Controls.Add(btnEmployee);
            Controls.Add(btnAdministrator);
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS-System-User";
            Load += frmLoginPage_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdministrator;
        private Button btnEmployee;
    }
}
