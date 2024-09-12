namespace csPOS_System_Management
{
    partial class frmRevenue
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
            lblRevenue = new Label();
            SuspendLayout();
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.ForeColor = SystemColors.ActiveCaptionText;
            lblRevenue.Location = new Point(275, 186);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(242, 65);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "REVENUE";
            lblRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblRevenue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRevenue";
            Text = "frmRevenue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRevenue;
    }
}