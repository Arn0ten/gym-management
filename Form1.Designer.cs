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
            pictureBox1 = new PictureBox();
            btnAdministrator = new Button();
            pictureBox2 = new PictureBox();
            btnEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.icons8_admin_settings_male_50;
            pictureBox1.Location = new Point(81, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAdministrator
            // 
            btnAdministrator.BackColor = Color.Lime;
            btnAdministrator.Font = new Font("Arial", 18F, FontStyle.Bold);
            btnAdministrator.ForeColor = Color.White;
            btnAdministrator.Location = new Point(69, 108);
            btnAdministrator.Name = "btnAdministrator";
            btnAdministrator.Size = new Size(238, 78);
            btnAdministrator.TabIndex = 3;
            btnAdministrator.Text = "Administrator";
            btnAdministrator.TextAlign = ContentAlignment.MiddleRight;
            btnAdministrator.UseVisualStyleBackColor = false;
            btnAdministrator.Click += btnAdministrator_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.icons8_admin_50;
            pictureBox2.Location = new Point(342, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnEmployee.Font = new Font("Arial", 18F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.White;
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
            Controls.Add(pictureBox2);
            Controls.Add(btnEmployee);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdministrator);
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS-System-User";
            Load += frmLoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnAdministrator;
        private PictureBox pictureBox2;
        private Button btnEmployee;
    }
}
