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
            btnMenu = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            lblAmout = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblProductName = new Label();
            panel2 = new Panel();
            label7 = new Label();
            lblTotal = new Label();
            label5 = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnDiscount = new Button();
            btnComment = new Button();
            btnCustomer = new Button();
            button12 = new Button();
            btnLock = new Button();
            btnRefund = new Button();
            btnPayment = new Button();
            btnSaveSale = new Button();
            button17 = new Button();
            btnVoidOrder = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            txtSearchProducts = new TextBox();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCashDrawer = new Button();
            btnMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Black;
            btnMenu.BorderStyle = BorderStyle.Fixed3D;
            btnMenu.Controls.Add(panel5);
            btnMenu.Controls.Add(panel4);
            btnMenu.ForeColor = SystemColors.Desktop;
            btnMenu.Location = new Point(4, 48);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(730, 532);
            btnMenu.TabIndex = 0;
            btnMenu.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 192);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(-2, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(732, 2);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(lblAmout);
            panel4.Controls.Add(lblPrice);
            panel4.Controls.Add(lblQuantity);
            panel4.Controls.Add(lblProductName);
            panel4.Location = new Point(-2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(730, 41);
            panel4.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTax);
            panel2.Controls.Add(lblSubtotal);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.Desktop;
            panel2.Location = new Point(4, 580);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 114);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(452, 49);
            label7.Name = "label7";
            label7.Size = new Size(278, 21);
            label7.TabIndex = 10;
            label7.Text = "  - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(666, 66);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 30);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(460, 72);
            label5.Name = "label5";
            label5.Size = new Size(56, 22);
            label5.TabIndex = 8;
            label5.Text = "Total";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.ForeColor = Color.White;
            lblTax.Location = new Point(680, 32);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(44, 20);
            lblTax.TabIndex = 7;
            lblTax.Text = "0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(680, 9);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(44, 20);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(460, 36);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Tax";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Subtotal";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 192);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(4, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(1359, 2);
            panel3.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnDelete.Image = Properties.Resources.icons8_x_50;
            btnDelete.Location = new Point(739, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 101);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button2.Location = new Point(896, 52);
            button2.Name = "button2";
            button2.Size = new Size(153, 101);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button3.Location = new Point(1054, 52);
            button3.Name = "button3";
            button3.Size = new Size(153, 101);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button4.Location = new Point(1212, 52);
            button4.Name = "button4";
            button4.Size = new Size(153, 101);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button5.Location = new Point(739, 155);
            button5.Name = "button5";
            button5.Size = new Size(206, 59);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button6.Location = new Point(948, 155);
            button6.Name = "button6";
            button6.Size = new Size(206, 59);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button7.Location = new Point(1158, 155);
            button7.Name = "button7";
            button7.Size = new Size(206, 59);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.FromArgb(64, 64, 64);
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnDiscount.Image = Properties.Resources.icons8_discount_60;
            btnDiscount.Location = new Point(739, 447);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(153, 80);
            btnDiscount.TabIndex = 10;
            btnDiscount.Text = "Discount";
            btnDiscount.TextAlign = ContentAlignment.BottomCenter;
            btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnComment
            // 
            btnComment.BackColor = Color.FromArgb(64, 64, 64);
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnComment.Image = Properties.Resources.icons8_comment_50;
            btnComment.Location = new Point(896, 447);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(153, 80);
            btnComment.TabIndex = 11;
            btnComment.Text = "Comment";
            btnComment.TextAlign = ContentAlignment.BottomCenter;
            btnComment.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnCustomer.Location = new Point(1053, 447);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(153, 80);
            btnCustomer.TabIndex = 12;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.BottomCenter;
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(64, 64, 64);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button12.Location = new Point(1210, 447);
            button12.Name = "button12";
            button12.Size = new Size(153, 80);
            button12.TabIndex = 13;
            button12.Text = "button12";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(64, 64, 64);
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnLock.Image = Properties.Resources.icons8_lock_502;
            btnLock.Location = new Point(739, 531);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(153, 80);
            btnLock.TabIndex = 14;
            btnLock.Text = "Lock";
            btnLock.TextAlign = ContentAlignment.BottomCenter;
            btnLock.UseVisualStyleBackColor = false;
            // 
            // btnRefund
            // 
            btnRefund.BackColor = Color.FromArgb(64, 64, 64);
            btnRefund.FlatStyle = FlatStyle.Flat;
            btnRefund.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnRefund.Image = Properties.Resources.icons8_refund_50;
            btnRefund.Location = new Point(896, 531);
            btnRefund.Name = "btnRefund";
            btnRefund.Size = new Size(153, 80);
            btnRefund.TabIndex = 15;
            btnRefund.Text = "Refund";
            btnRefund.TextAlign = ContentAlignment.BottomCenter;
            btnRefund.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.ForestGreen;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnPayment.Image = Properties.Resources.icons8_pay_48;
            btnPayment.Location = new Point(1054, 531);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(308, 80);
            btnPayment.TabIndex = 10;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.BottomCenter;
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnSaveSale
            // 
            btnSaveSale.BackColor = Color.FromArgb(64, 64, 64);
            btnSaveSale.FlatStyle = FlatStyle.Flat;
            btnSaveSale.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnSaveSale.Image = Properties.Resources.icons8_save_50;
            btnSaveSale.Location = new Point(739, 615);
            btnSaveSale.Name = "btnSaveSale";
            btnSaveSale.Size = new Size(153, 80);
            btnSaveSale.TabIndex = 10;
            btnSaveSale.Text = "Save Sale";
            btnSaveSale.TextAlign = ContentAlignment.BottomCenter;
            btnSaveSale.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(64, 64, 64);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button17.Location = new Point(896, 615);
            button17.Name = "button17";
            button17.Size = new Size(153, 80);
            button17.TabIndex = 16;
            button17.Text = "button17";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = false;
            // 
            // btnVoidOrder
            // 
            btnVoidOrder.BackColor = Color.Red;
            btnVoidOrder.BackgroundImageLayout = ImageLayout.None;
            btnVoidOrder.FlatStyle = FlatStyle.Flat;
            btnVoidOrder.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnVoidOrder.Image = Properties.Resources.icons8_delete_48;
            btnVoidOrder.Location = new Point(1053, 615);
            btnVoidOrder.Name = "btnVoidOrder";
            btnVoidOrder.Size = new Size(153, 80);
            btnVoidOrder.TabIndex = 17;
            btnVoidOrder.Text = "Void Order";
            btnVoidOrder.TextAlign = ContentAlignment.BottomCenter;
            btnVoidOrder.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(64, 64, 64);
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button19.Image = Properties.Resources.icons8_hamburger_menu_48;
            button19.Location = new Point(1210, 615);
            button19.Name = "button19";
            button19.Size = new Size(153, 80);
            button19.TabIndex = 18;
            button19.Text = "Menu";
            button19.TextAlign = ContentAlignment.BottomCenter;
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(64, 64, 64);
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button20.Location = new Point(1158, 216);
            button20.Name = "button20";
            button20.Size = new Size(206, 59);
            button20.TabIndex = 21;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(64, 64, 64);
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button21.Location = new Point(948, 216);
            button21.Name = "button21";
            button21.Size = new Size(206, 59);
            button21.TabIndex = 20;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(64, 64, 64);
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            button22.Location = new Point(739, 216);
            button22.Name = "button22";
            button22.Size = new Size(206, 59);
            button22.TabIndex = 19;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = false;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(168, 12);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Products";
            txtSearchProducts.Size = new Size(566, 23);
            txtSearchProducts.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_50;
            pictureBox1.Location = new Point(142, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(739, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(71, 26);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_tag_50;
            pictureBox2.Location = new Point(99, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_barcode_50_white;
            pictureBox3.Location = new Point(68, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // btnCashDrawer
            // 
            btnCashDrawer.BackColor = Color.FromArgb(64, 64, 64);
            btnCashDrawer.BackgroundImageLayout = ImageLayout.None;
            btnCashDrawer.FlatStyle = FlatStyle.Flat;
            btnCashDrawer.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnCashDrawer.ForeColor = Color.White;
            btnCashDrawer.Image = Properties.Resources.icons8_drawer_50;
            btnCashDrawer.Location = new Point(739, 363);
            btnCashDrawer.Name = "btnCashDrawer";
            btnCashDrawer.Size = new Size(153, 80);
            btnCashDrawer.TabIndex = 9;
            btnCashDrawer.Text = "Cash Drawer";
            btnCashDrawer.TextAlign = ContentAlignment.BottomCenter;
            btnCashDrawer.UseVisualStyleBackColor = false;
            // 
            // frmMainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1370, 729);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSearch);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearchProducts);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button19);
            Controls.Add(btnVoidOrder);
            Controls.Add(button17);
            Controls.Add(btnSaveSale);
            Controls.Add(btnPayment);
            Controls.Add(btnRefund);
            Controls.Add(btnLock);
            Controls.Add(button12);
            Controls.Add(btnCustomer);
            Controls.Add(btnComment);
            Controls.Add(btnDiscount);
            Controls.Add(btnCashDrawer);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnDelete);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnMenu);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel";
            WindowState = FormWindowState.Maximized;
            Load += frmMainPanel_Load;
            btnMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel btnMenu;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblProductName;
        private Label lblAmout;
        private Label lblPrice;
        private Label lblQuantity;
        private Label label1;
        private Label lblTotal;
        private Label label5;
        private Label lblTax;
        private Label lblSubtotal;
        private Label label2;
        private Button btnDelete;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnDiscount;
        private Button btnComment;
        private Button btnCustomer;
        private Button button12;
        private Button btnLock;
        private Button btnRefund;
        private Button btnPayment;
        private Button btnSaveSale;
        private Button button17;
        private Button btnVoidOrder;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Label label7;
        private Panel panel5;
        private TextBox txtSearchProducts;
        private PictureBox pictureBox1;
        private Button btnSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnCashDrawer;
    }
}