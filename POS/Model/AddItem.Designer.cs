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
            rbActive = new RadioButton();
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
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 115);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(631, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 93);
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
            lblTitle.Location = new Point(510, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "الاصناف";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 81);
            panel1.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Janna LT", 9.749999F);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(189, 17);
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
            btnClose.Location = new Point(47, 17);
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
            label1.Location = new Point(669, 151);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 26;
            label1.Text = "الصنف";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(310, 141);
            txtItemName.Name = "txtItemName";
            txtItemName.RightToLeft = RightToLeft.Yes;
            txtItemName.Size = new Size(340, 39);
            txtItemName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(669, 239);
            label2.Name = "label2";
            label2.Size = new Size(54, 31);
            label2.TabIndex = 28;
            label2.Text = "السعر";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(310, 229);
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Size = new Size(340, 39);
            txtPrice.TabIndex = 27;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(310, 324);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.RightToLeft = RightToLeft.Yes;
            cbCategory.Size = new Size(340, 39);
            cbCategory.TabIndex = 29;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(681, 327);
            label3.Name = "label3";
            label3.Size = new Size(46, 31);
            label3.TabIndex = 30;
            label3.Text = "الفئة";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(58, 301);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(121, 48);
            btnBrowse.TabIndex = 32;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtThumb
            // 
            txtThumb.Image = (Image)resources.GetObject("txtThumb.Image");
            txtThumb.Location = new Point(58, 168);
            txtThumb.Margin = new Padding(3, 4, 3, 4);
            txtThumb.Name = "txtThumb";
            txtThumb.Size = new Size(121, 125);
            txtThumb.SizeMode = PictureBoxSizeMode.CenterImage;
            txtThumb.TabIndex = 31;
            txtThumb.TabStop = false;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbActive.Location = new Point(660, 382);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(67, 27);
            rbActive.TabIndex = 33;
            rbActive.TabStop = true;
            rbActive.Text = "ظاهر";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 493);
            Controls.Add(rbActive);
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
        private Label label3;
        private Button btnBrowse;
        private PictureBox txtThumb;
        private RadioButton rbActive;
        public ComboBox cbCategory;
    }
}