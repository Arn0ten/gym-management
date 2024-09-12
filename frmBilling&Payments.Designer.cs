namespace csPOS_System_Management
{
    partial class frmBilling_Payments
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
            lblDashboard = new Label();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.Anchor = AnchorStyles.None;
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ActiveCaptionText;
            lblDashboard.Location = new Point(141, 187);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(528, 65);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "BILLING && PAYMENTS";
            lblDashboard.TextAlign = ContentAlignment.MiddleCenter;
            lblDashboard.Click += lblDashboard_Click;
            // 
            // frmBilling_Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBilling_Payments";
            Text = "frmBilling_Payments";
            Load += frmBilling_Payments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
    }
}