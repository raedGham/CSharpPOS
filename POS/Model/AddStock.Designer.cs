namespace POS.Model
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtUnitPrice = new TextBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            txtQty = new TextBox();
            label4 = new Label();
            cbUnit = new ComboBox();
            label5 = new Label();
            cbSupplier = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtSalesPrice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtReorder = new TextBox();
            txtBarcode = new TextBox();
            label10 = new Label();
            dtExpiryDate1 = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 115);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(976, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(843, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(94, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " المواد";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 596);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 101);
            panel1.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Janna LT", 9.749999F);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(197, 27);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Janna LT", 9.749999F);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(56, 27);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(103, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(970, 234);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 26;
            label1.Text = "اسم المادة";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(376, 234);
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = RightToLeft.Yes;
            txtDescription.Size = new Size(575, 39);
            txtDescription.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 239);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 28;
            label2.Text = "سعر الشراء";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(61, 231);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.RightToLeft = RightToLeft.Yes;
            txtUnitPrice.Size = new Size(172, 39);
            txtUnitPrice.TabIndex = 27;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(622, 325);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.RightToLeft = RightToLeft.Yes;
            cbCategory.Size = new Size(329, 39);
            cbCategory.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(492, 333);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 32;
            label3.Text = "الكمية المتوفرة";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(376, 325);
            txtQty.Name = "txtQty";
            txtQty.RightToLeft = RightToLeft.Yes;
            txtQty.Size = new Size(110, 39);
            txtQty.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1011, 328);
            label4.Name = "label4";
            label4.Size = new Size(46, 31);
            label4.TabIndex = 33;
            label4.Text = "الفئة";
            // 
            // cbUnit
            // 
            cbUnit.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(61, 325);
            cbUnit.Margin = new Padding(3, 4, 3, 4);
            cbUnit.Name = "cbUnit";
            cbUnit.RightToLeft = RightToLeft.Yes;
            cbUnit.Size = new Size(172, 39);
            cbUnit.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(280, 333);
            label5.Name = "label5";
            label5.Size = new Size(56, 31);
            label5.TabIndex = 35;
            label5.Text = "الوحدة";
            // 
            // cbSupplier
            // 
            cbSupplier.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(376, 416);
            cbSupplier.Margin = new Padding(3, 4, 3, 4);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.RightToLeft = RightToLeft.Yes;
            cbSupplier.Size = new Size(575, 39);
            cbSupplier.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1011, 424);
            label6.Name = "label6";
            label6.Size = new Size(47, 31);
            label6.TabIndex = 37;
            label6.Text = "التاجر";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(248, 424);
            label7.Name = "label7";
            label7.Size = new Size(88, 31);
            label7.TabIndex = 39;
            label7.Text = "سعر المبيع";
            // 
            // txtSalesPrice
            // 
            txtSalesPrice.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalesPrice.Location = new Point(61, 416);
            txtSalesPrice.Name = "txtSalesPrice";
            txtSalesPrice.RightToLeft = RightToLeft.Yes;
            txtSalesPrice.Size = new Size(172, 39);
            txtSalesPrice.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(954, 513);
            label8.Name = "label8";
            label8.Size = new Size(103, 31);
            label8.TabIndex = 41;
            label8.Text = "تاريخ الصلاحية";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(492, 508);
            label9.Name = "label9";
            label9.Size = new Size(127, 31);
            label9.TabIndex = 43;
            label9.Text = "كمية إعادة الطلب";
            // 
            // txtReorder
            // 
            txtReorder.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorder.Location = new Point(376, 505);
            txtReorder.Name = "txtReorder";
            txtReorder.RightToLeft = RightToLeft.Yes;
            txtReorder.Size = new Size(110, 39);
            txtReorder.TabIndex = 42;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(705, 158);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.RightToLeft = RightToLeft.Yes;
            txtBarcode.Size = new Size(246, 39);
            txtBarcode.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(982, 166);
            label10.Name = "label10";
            label10.Size = new Size(76, 31);
            label10.TabIndex = 45;
            label10.Text = "Barcode";
           
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 697);
            Controls.Add(dtExpiryDate);
            Controls.Add(label10);
            Controls.Add(txtBarcode);
            Controls.Add(label9);
            Controls.Add(txtReorder);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtSalesPrice);
            Controls.Add(label6);
            Controls.Add(cbSupplier);
            Controls.Add(label5);
            Controls.Add(cbUnit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQty);
            Controls.Add(cbCategory);
            Controls.Add(label2);
            Controls.Add(txtUnitPrice);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStock";
            Text = "AddStock";
            Load += AddStock_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Panel panel1;
        private Button btnSave;
        private Button btnClose;
        private Label label1;
        public TextBox txtDescription;
        private Label label2;
        public TextBox txtUnitPrice;
        public ComboBox cbCategory;
        private Label label3;
        public TextBox txtQty;
        private Label label4;
        public ComboBox cbUnit;
        private Label label5;
        public ComboBox cbSupplier;
        private Label label6;
        private Label label7;
        public TextBox txtSalesPrice;
        private Label label8;
        public TextBox dtExpiryDate;
        private Label label9;
        public TextBox txtReorder;
        public TextBox txtBarcode;
        private Label label10;
        private DateTimePicker dtExpiryDate1;
    }
}