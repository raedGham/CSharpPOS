namespace POS.View
{
    partial class staffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnNew = new Button();
            lblRecords = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvAddress = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(lblRecords);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 71);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(839, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 16.1999989F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(642, 17);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 7;
            label3.Text = "لائحة عمال التوصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Bold);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(418, 28);
            label2.Name = "label2";
            label2.Size = new Size(37, 26);
            label2.TabIndex = 5;
            label2.Text = "بحث";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Janna LT", 10.1999989F);
            txtSearch.Location = new Point(216, 25);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(196, 33);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Janna LT", 9F);
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(498, 24);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 30);
            btnNew.TabIndex = 3;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRecords.ForeColor = Color.Gainsboro;
            lblRecords.Location = new Point(88, 31);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(17, 19);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(111, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 2;
            label1.Text = "عدد السجلات";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1631, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(1500, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(122, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لائحة الزبائن";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-48, 73);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 513);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Janna LT", 10.1999989F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, dgvID, dgvName, dgvAddress, dgvPhone, dgvEdit, dgvDel });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Janna LT", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(51, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(945, 509);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Sn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 30;
            // 
            // dgvID
            // 
            dataGridViewCellStyle2.Font = new Font("Janna LT", 10.1999989F);
            dgvID.DefaultCellStyle = dataGridViewCellStyle2;
            dgvID.HeaderText = "الرمز";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.Width = 70;
            // 
            // dgvName
            // 
            dataGridViewCellStyle3.Font = new Font("Janna LT", 10.1999989F);
            dgvName.DefaultCellStyle = dataGridViewCellStyle3;
            dgvName.HeaderText = "الاسم";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.Width = 250;
            // 
            // dgvAddress
            // 
            dgvAddress.HeaderText = "العنوان";
            dgvAddress.MinimumWidth = 6;
            dgvAddress.Name = "dgvAddress";
            dgvAddress.Width = 300;
            // 
            // dgvPhone
            // 
            dgvPhone.HeaderText = "هاتف";
            dgvPhone.MinimumWidth = 6;
            dgvPhone.Name = "dgvPhone";
            dgvPhone.Width = 125;
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "Edit";
            dgvEdit.Image = (Image)resources.GetObject("dgvEdit.Image");
            dgvEdit.MinimumWidth = 6;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.Resizable = DataGridViewTriState.True;
            dgvEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvEdit.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.HeaderText = "Del";
            dgvDel.Image = (Image)resources.GetObject("dgvDel.Image");
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.Resizable = DataGridViewTriState.True;
            dgvDel.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvDel.Width = 50;
            // 
            // staffList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 583);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "staffList";
            Text = "staff";
            Load += staffList_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox txtSearch;
        private Button btnNew;
        private Label lblRecords;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvAddress;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}