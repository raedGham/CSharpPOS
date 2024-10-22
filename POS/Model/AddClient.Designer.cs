namespace POS.Model
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 115);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(861, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(769, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "الزبائن";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 102);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(79, 37);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.Yes;
            btnClose.Size = new Size(103, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "إغلاق";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(219, 37);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 111);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(1138, 357);
            panel3.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(208, 165);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(647, 39);
            txtName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(874, 165);
            label1.Name = "label1";
            label1.Size = new Size(56, 31);
            label1.TabIndex = 6;
            label1.Text = "الاسم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(874, 233);
            label2.Name = "label2";
            label2.Size = new Size(61, 31);
            label2.TabIndex = 8;
            label2.Text = "الغنوان";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(208, 233);
            txtAddress.Name = "txtAddress";
            txtAddress.RightToLeft = RightToLeft.Yes;
            txtAddress.Size = new Size(647, 39);
            txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(874, 305);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(58, 31);
            label3.TabIndex = 10;
            label3.Text = "الهاتف";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(647, 305);
            txtPhone.Name = "txtPhone";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(208, 39);
            txtPhone.TabIndex = 9;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 576);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddClient";
            Text = "AddClient";
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
        private Button btnClose;
        private Button btnSave;
        private Panel panel3;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtPhone;
    }
}