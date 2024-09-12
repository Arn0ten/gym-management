namespace csPOS_System_Management
{
    partial class frmAttendanceTracking
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
            lblAttendanceTracking = new Label();
            SuspendLayout();
            // 
            // lblAttendanceTracking
            // 
            lblAttendanceTracking.AutoSize = true;
            lblAttendanceTracking.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendanceTracking.ForeColor = SystemColors.ActiveCaptionText;
            lblAttendanceTracking.Location = new Point(108, 197);
            lblAttendanceTracking.Name = "lblAttendanceTracking";
            lblAttendanceTracking.Size = new Size(595, 65);
            lblAttendanceTracking.TabIndex = 3;
            lblAttendanceTracking.Text = "ATTENDANCE TRACKING";
            lblAttendanceTracking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAttendanceTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAttendanceTracking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendanceTracking";
            Text = "frmAttendanceTracking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAttendanceTracking;
    }
}