namespace POS.Model
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            txtItemName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            btnBrowse = new Button();
            txtThumb = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtThumb).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 86);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(446, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "الاصناف";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 309);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 61);
            panel1.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Janna LT", 9.749999F);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(165, 13);
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
            // btnClose
            // 
            btnClose.Font = new Font("Janna LT", 9.749999F);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(41, 13);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(585, 113);
            label1.Name = "label1";
            label1.Size = new Size(49, 26);
            label1.TabIndex = 26;
            label1.Text = "الصنف";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(271, 106);
            txtItemName.Margin = new Padding(3, 2, 3, 2);
            txtItemName.Name = "txtItemName";
            txtItemName.RightToLeft = RightToLeft.Yes;
            txtItemName.Size = new Size(298, 33);
            txtItemName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(585, 179);
            label2.Name = "label2";
            label2.Size = new Size(46, 26);
            label2.TabIndex = 28;
            label2.Text = "السعر";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(271, 172);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Size = new Size(298, 33);
            txtPrice.TabIndex = 27;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(271, 243);
            cbCategory.Name = "cbCategory";
            cbCategory.RightToLeft = RightToLeft.Yes;
            cbCategory.Size = new Size(298, 32);
            cbCategory.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(596, 245);
            label3.Name = "label3";
            label3.Size = new Size(38, 26);
            label3.TabIndex = 30;
            label3.Text = "الفئة";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(51, 226);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(106, 36);
            btnBrowse.TabIndex = 32;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtThumb
            // 
            txtThumb.Image = (Image)resources.GetObject("txtThumb.Image");
            txtThumb.Location = new Point(51, 126);
            txtThumb.Name = "txtThumb";
            txtThumb.Size = new Size(106, 94);
            txtThumb.SizeMode = PictureBoxSizeMode.CenterImage;
            txtThumb.TabIndex = 31;
            txtThumb.TabStop = false;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 370);
            Controls.Add(btnBrowse);
            Controls.Add(txtThumb);
            Controls.Add(label3);
            Controls.Add(cbCategory);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(txtItemName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddItem";
            Text = "AddItem";
            Load += AddItem_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtThumb).EndInit();
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
        public TextBox txtItemName;
        private Label label2;
        public TextBox txtPrice;
        private ComboBox cbCategory;
        private Label label3;
        private Button btnBrowse;
        private PictureBox txtThumb;
    }
}