namespace POS.SalesInvoice
{
    partial class SalesInvoiceList
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceList));
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            txtSearch = new TextBox();
            btnNew = new Button();
            lblRecords = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvInvDate = new DataGridViewTextBoxColumn();
            dgvInvTime = new DataGridViewTextBoxColumn();
            dgvTotal = new DataGridViewTextBoxColumn();
            dgvPaid = new DataGridViewTextBoxColumn();
            dgvDiscount = new DataGridViewTextBoxColumn();
            dgvType = new DataGridViewTextBoxColumn();
            dgvDeliveryID = new DataGridViewTextBoxColumn();
            dgvDeliveryTime = new DataGridViewTextBoxColumn();
            dgvClientID = new DataGridViewTextBoxColumn();
            dgvPrinted = new DataGridViewTextBoxColumn();
            dgvCashIN = new DataGridViewTextBoxColumn();
            dgvCashOUT = new DataGridViewTextBoxColumn();
            dgvSlipWI = new DataGridViewTextBoxColumn();
            dgvDelivered = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, dgvID, dgvInvDate, dgvInvTime, dgvTotal, dgvPaid, dgvDiscount, dgvType, dgvDeliveryID, dgvDeliveryTime, dgvClientID, dgvPrinted, dgvCashIN, dgvCashOUT, dgvSlipWI, dgvDelivered, dgvEdit, dgvDel });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(0, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 39;
            dataGridView1.Size = new Size(1480, 563);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(lblRecords);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 81);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 16.1999989F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(1148, 16);
            label3.Name = "label3";
            label3.Size = new Size(212, 52);
            label3.TabIndex = 7;
            label3.Text = "لائحة فواتير المبيع";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1385, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 10.1999989F, FontStyle.Bold);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(435, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 31);
            label2.TabIndex = 5;
            label2.Text = "بحث";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Janna LT", 10.1999989F);
            txtSearch.Location = new Point(206, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 39);
            txtSearch.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Janna LT", 9F);
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(727, 26);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(76, 38);
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
            lblRecords.Location = new Point(45, 33);
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
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 2;
            label1.Text = "عدد السجلات";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2257, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
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
            lblTitle.Location = new Point(2107, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لائحة الزبائن";
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
            dataGridViewCellStyle1.Font = new Font("Janna LT", 10.1999989F);
            dgvID.DefaultCellStyle = dataGridViewCellStyle1;
            dgvID.HeaderText = "الرمز";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.Width = 70;
            // 
            // dgvInvDate
            // 
            dataGridViewCellStyle2.Font = new Font("Janna LT", 10.1999989F);
            dgvInvDate.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInvDate.HeaderText = "التاريخ";
            dgvInvDate.MinimumWidth = 6;
            dgvInvDate.Name = "dgvInvDate";
            dgvInvDate.Width = 120;
            // 
            // dgvInvTime
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            dgvInvTime.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInvTime.HeaderText = "الوقت";
            dgvInvTime.MinimumWidth = 6;
            dgvInvTime.Name = "dgvInvTime";
            dgvInvTime.Width = 120;
            // 
            // dgvTotal
            // 
            dgvTotal.HeaderText = "الاجمالي";
            dgvTotal.MinimumWidth = 6;
            dgvTotal.Name = "dgvTotal";
            dgvTotal.Width = 125;
            // 
            // dgvPaid
            // 
            dgvPaid.HeaderText = "مدفوع";
            dgvPaid.MinimumWidth = 6;
            dgvPaid.Name = "dgvPaid";
            dgvPaid.Width = 125;
            // 
            // dgvDiscount
            // 
            dgvDiscount.HeaderText = "حسم";
            dgvDiscount.MinimumWidth = 6;
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.Width = 125;
            // 
            // dgvType
            // 
            dgvType.HeaderText = "النوع";
            dgvType.MinimumWidth = 6;
            dgvType.Name = "dgvType";
            dgvType.Width = 125;
            // 
            // dgvDeliveryID
            // 
            dgvDeliveryID.HeaderText = "رمز العامل";
            dgvDeliveryID.MinimumWidth = 6;
            dgvDeliveryID.Name = "dgvDeliveryID";
            dgvDeliveryID.Width = 125;
            // 
            // dgvDeliveryTime
            // 
            dgvDeliveryTime.HeaderText = "وقت التوصيل";
            dgvDeliveryTime.MinimumWidth = 6;
            dgvDeliveryTime.Name = "dgvDeliveryTime";
            dgvDeliveryTime.Width = 125;
            // 
            // dgvClientID
            // 
            dgvClientID.HeaderText = "رمز الزبون";
            dgvClientID.MinimumWidth = 6;
            dgvClientID.Name = "dgvClientID";
            dgvClientID.Width = 125;
            // 
            // dgvPrinted
            // 
            dgvPrinted.HeaderText = "طبعت";
            dgvPrinted.MinimumWidth = 6;
            dgvPrinted.Name = "dgvPrinted";
            dgvPrinted.Width = 125;
            // 
            // dgvCashIN
            // 
            dgvCashIN.HeaderText = "كاش داخل";
            dgvCashIN.MinimumWidth = 6;
            dgvCashIN.Name = "dgvCashIN";
            dgvCashIN.Width = 125;
            // 
            // dgvCashOUT
            // 
            dgvCashOUT.HeaderText = "كاش خارج";
            dgvCashOUT.MinimumWidth = 6;
            dgvCashOUT.Name = "dgvCashOUT";
            dgvCashOUT.Width = 125;
            // 
            // dgvSlipWI
            // 
            dgvSlipWI.HeaderText = "SlipWI";
            dgvSlipWI.MinimumWidth = 6;
            dgvSlipWI.Name = "dgvSlipWI";
            dgvSlipWI.Width = 125;
            // 
            // dgvDelivered
            // 
            dgvDelivered.HeaderText = "تم التوصيل";
            dgvDelivered.MinimumWidth = 6;
            dgvDelivered.Name = "dgvDelivered";
            dgvDelivered.Width = 125;
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
            // SalesInvoiceList
            // 
            AutoScaleDimensions = new SizeF(9F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 657);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "SalesInvoiceList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "SalesInvoiceList";
            Load += SalesInvoiceList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private TextBox txtSearch;
        private Button btnNew;
        private Label lblRecords;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvInvDate;
        private DataGridViewTextBoxColumn dgvInvTime;
        private DataGridViewTextBoxColumn dgvTotal;
        private DataGridViewTextBoxColumn dgvPaid;
        private DataGridViewTextBoxColumn dgvDiscount;
        private DataGridViewTextBoxColumn dgvType;
        private DataGridViewTextBoxColumn dgvDeliveryID;
        private DataGridViewTextBoxColumn dgvDeliveryTime;
        private DataGridViewTextBoxColumn dgvClientID;
        private DataGridViewTextBoxColumn dgvPrinted;
        private DataGridViewTextBoxColumn dgvCashIN;
        private DataGridViewTextBoxColumn dgvCashOUT;
        private DataGridViewTextBoxColumn dgvSlipWI;
        private DataGridViewTextBoxColumn dgvDelivered;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}