namespace csPOS_System_Management
{
    partial class frmClasses_Schedules
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
            lblCLassesSchedules = new Label();
            SuspendLayout();
            // 
            // lblCLassesSchedules
            // 
            lblCLassesSchedules.AutoSize = true;
            lblCLassesSchedules.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCLassesSchedules.ForeColor = SystemColors.ActiveCaptionText;
            lblCLassesSchedules.Location = new Point(129, 188);
            lblCLassesSchedules.Name = "lblCLassesSchedules";
            lblCLassesSchedules.Size = new Size(560, 65);
            lblCLassesSchedules.TabIndex = 1;
            lblCLassesSchedules.Text = "CLASSES && SCHEDULES";
            lblCLassesSchedules.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmClasses_Schedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCLassesSchedules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClasses_Schedules";
            Text = "frmClasses_Schedules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCLassesSchedules;
    }
}