namespace POS.Model
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            lblTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panel1 = new Panel();
            btnSave = new Button();
            label3 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtSupply = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(397, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "التجّار";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 86);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 83);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(615, 268);
            panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Janna LT", 9.749999F);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(49, 20);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(90, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 374);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 76);
            panel1.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Janna LT", 9.749999F);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(172, 20);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(90, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 248);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(47, 26);
            label3.TabIndex = 26;
            label3.Text = "الهاتف";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(387, 248);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(98, 33);
            txtPhone.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 194);
            label2.Name = "label2";
            label2.Size = new Size(51, 26);
            label2.TabIndex = 24;
            label2.Text = "العنوان";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(36, 194);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.RightToLeft = RightToLeft.Yes;
            txtAddress.Size = new Size(449, 33);
            txtAddress.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 143);
            label1.Name = "label1";
            label1.Size = new Size(48, 26);
            label1.TabIndex = 22;
            label1.Text = "الاسم";
            // 
            // txtName
            // 
            txtName.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(36, 143);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(449, 33);
            txtName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(491, 311);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(74, 26);
            label4.TabIndex = 27;
            label4.Text = "نوع البضاعة";
            // 
            // txtSupply
            // 
            txtSupply.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupply.Location = new Point(36, 304);
            txtSupply.Margin = new Padding(3, 2, 3, 2);
            txtSupply.Name = "txtSupply";
            txtSupply.RightToLeft = RightToLeft.Yes;
            txtSupply.Size = new Size(449, 33);
            txtSupply.TabIndex = 28;
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(txtSupply);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "AddSupplier";
            Text = "AddSupplier";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Panel panel1;
        private Button btnSave;
        private Label label3;
        public TextBox txtPhone;
        private Label label2;
        public TextBox txtAddress;
        private Label label1;
        public TextBox txtName;
        private Label label4;
        public TextBox txtSupply;
    }
}