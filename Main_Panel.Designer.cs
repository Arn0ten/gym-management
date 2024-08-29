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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblProductName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAmout = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel4);
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(4, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 532);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.Desktop;
            panel2.Location = new Point(4, 580);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 114);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(4, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(1245, 10);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Controls.Add(lblAmout);
            panel4.Controls.Add(lblPrice);
            panel4.Controls.Add(lblQuantity);
            panel4.Controls.Add(lblProductName);
            panel4.Location = new Point(-2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(730, 41);
            panel4.TabIndex = 0;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(5, 12);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(122, 18);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(387, 12);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(76, 18);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(523, 12);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 18);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblAmout
            // 
            lblAmout.AutoSize = true;
            lblAmout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmout.ForeColor = Color.White;
            lblAmout.Location = new Point(628, 12);
            lblAmout.Name = "lblAmout";
            lblAmout.Size = new Size(70, 18);
            lblAmout.TabIndex = 3;
            lblAmout.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(495, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(495, 36);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(680, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(680, 32);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(495, 72);
            label5.Name = "label5";
            label5.Size = new Size(56, 22);
            label5.TabIndex = 8;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(666, 66);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 9;
            label6.Text = "0.00";
            // 
            // frmMainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1261, 729);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label lblProductName;
        private Label lblAmout;
        private Label lblPrice;
        private Label lblQuantity;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}