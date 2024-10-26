namespace POS.View
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnNew = new Button();
            lblRecords = new Label();
            label1 = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvItem = new DataGridViewTextBoxColumn();
            dgvCategory = new DataGridViewTextBoxColumn();
            dgvCatID = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(lblRecords);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 124);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1023, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 109);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Janna LT", 16.1999989F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(837, 37);
            label5.Name = "label5";
            label5.Size = new Size(165, 52);
            label5.TabIndex = 10;
            label5.Text = "لائحة الاصناف";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Janna LT", 16.1999989F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(1757, 39);
            label4.Name = "label4";
            label4.Size = new Size(177, 52);
            label4.TabIndex = 9;
            label4.Text = "لائحة المكونات";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 16.1999989F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(2654, 39);
            label3.Name = "label3";
            label3.Size = new Size(234, 52);
            label3.TabIndex = 7;
            label3.Text = "لائحة وحدات القياس";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Bold);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(491, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 31);
            label2.TabIndex = 5;
            label2.Text = "بحث";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Janna LT", 10.1999989F);
            txtSearch.Location = new Point(261, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 39);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Janna LT", 9F);
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(591, 47);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(89, 40);
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
            lblRecords.Location = new Point(101, 55);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(20, 23);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 10.1999989F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(127, 52);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 2;
            label1.Text = "عدد السجلات";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 16.1999989F);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(3717, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لائحة الزبائن";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 131);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(1147, 543);
            panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Janna LT", 10.1999989F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, dgvID, dgvItem, dgvCategory, dgvCatID, dgvPrice, dgvEdit, dgvDel });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Janna LT", 10.1999989F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 39;
            dataGridView1.Size = new Size(1141, 541);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "تسلسلي";
            Column1.MinimumWidth = 30;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 80;
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
            // dgvItem
            // 
            dgvItem.HeaderText = "الصنف";
            dgvItem.MinimumWidth = 6;
            dgvItem.Name = "dgvItem";
            dgvItem.Width = 250;
            // 
            // dgvCategory
            // 
            dataGridViewCellStyle3.Font = new Font("Janna LT", 10.1999989F);
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.HeaderText = "الفئة";
            dgvCategory.MinimumWidth = 6;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Width = 175;
            // 
            // dgvCatID
            // 
            dgvCatID.HeaderText = "CatID";
            dgvCatID.MinimumWidth = 6;
            dgvCatID.Name = "dgvCatID";
            dgvCatID.Visible = false;
            dgvCatID.Width = 125;
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "سعر المبيع";
            dgvPrice.MinimumWidth = 6;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.Width = 125;
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
            // ItemList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 675);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ItemList";
            RightToLeft = RightToLeft.Yes;
            Text = "ItemList";
            Load += ItemList_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        
        private Label label3;
    
        private Label label2;
        private TextBox txtSearch;
        private Button btnNew;
        private Label lblRecords;
        private Label label1;
        
        private Label lblTitle;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvItem;
        private DataGridViewTextBoxColumn dgvCategory;
        private DataGridViewTextBoxColumn dgvCatID;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}