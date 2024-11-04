namespace POS.SalesInvoice
{
    partial class SalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoice));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            HeaderPanel = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            CategoryPanel = new FlowLayoutPanel();
            ProductPanel = new FlowLayoutPanel();
            InvoicePanel = new Panel();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            label2 = new Label();
            button10 = new Button();
            button9 = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtDeliveryTime = new DateTimePicker();
            cbClient = new ComboBox();
            cbDelivery = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnCash = new Button();
            btnToAccount = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            txtTime = new DateTimePicker();
            label3 = new Label();
            txtDate = new DateTimePicker();
            lbDate = new Label();
            lblInvNo = new Label();
            label1 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            dataGridView1 = new DataGridView();
            Sn = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvItemID = new DataGridViewTextBoxColumn();
            dgvItemDescription = new DataGridViewTextBoxColumn();
            dgvQty = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvAmount = new DataGridViewTextBoxColumn();
            FooterPanel = new Panel();
            lblSelectedQty = new Label();
            btnQtyUp = new Button();
            btnQtyDn = new Button();
            lblSelectedItem = new Label();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            InvoicePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            FooterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.MidnightBlue;
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Controls.Add(CategoryPanel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1245, 72);
            HeaderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1161, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CategoryPanel
            // 
            CategoryPanel.Location = new Point(299, 3);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(856, 69);
            CategoryPanel.TabIndex = 1;
            // 
            // ProductPanel
            // 
            ProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPanel.BackColor = SystemColors.ActiveCaption;
            ProductPanel.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPanel.Location = new Point(-1, 78);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.RightToLeft = RightToLeft.Yes;
            ProductPanel.Size = new Size(798, 644);
            ProductPanel.TabIndex = 1;
            // 
            // InvoicePanel
            // 
            InvoicePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            InvoicePanel.Controls.Add(panel1);
            InvoicePanel.Controls.Add(button10);
            InvoicePanel.Controls.Add(button9);
            InvoicePanel.Controls.Add(txtAddress);
            InvoicePanel.Controls.Add(txtPhone);
            InvoicePanel.Controls.Add(txtDeliveryTime);
            InvoicePanel.Controls.Add(cbClient);
            InvoicePanel.Controls.Add(cbDelivery);
            InvoicePanel.Controls.Add(label10);
            InvoicePanel.Controls.Add(label9);
            InvoicePanel.Controls.Add(label8);
            InvoicePanel.Controls.Add(label7);
            InvoicePanel.Controls.Add(label6);
            InvoicePanel.Controls.Add(label5);
            InvoicePanel.Controls.Add(btnCash);
            InvoicePanel.Controls.Add(btnToAccount);
            InvoicePanel.Controls.Add(btnNew);
            InvoicePanel.Controls.Add(btnSave);
            InvoicePanel.Controls.Add(btnDelete);
            InvoicePanel.Controls.Add(btnPrint);
            InvoicePanel.Controls.Add(lblTotal);
            InvoicePanel.Controls.Add(txtTime);
            InvoicePanel.Controls.Add(label3);
            InvoicePanel.Controls.Add(txtDate);
            InvoicePanel.Controls.Add(lbDate);
            InvoicePanel.Controls.Add(lblInvNo);
            InvoicePanel.Controls.Add(label1);
            InvoicePanel.Controls.Add(btnNext);
            InvoicePanel.Controls.Add(btnPrevious);
            InvoicePanel.Controls.Add(dataGridView1);
            InvoicePanel.Location = new Point(800, 78);
            InvoicePanel.Name = "InvoicePanel";
            InvoicePanel.Size = new Size(445, 712);
            InvoicePanel.TabIndex = 2;
            InvoicePanel.Paint += InvoicePanel_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Janna LT", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 178);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 100);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 29);
            panel1.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 3);
            label13.Name = "label13";
            label13.Size = new Size(60, 26);
            label13.TabIndex = 6;
            label13.Text = "الاجمالي";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(77, 3);
            label12.Name = "label12";
            label12.Size = new Size(46, 26);
            label12.TabIndex = 5;
            label12.Text = "السعر";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(122, 3);
            label11.Name = "label11";
            label11.Size = new Size(47, 26);
            label11.TabIndex = 4;
            label11.Text = "الكمية";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 3);
            label4.Name = "label4";
            label4.Size = new Size(50, 26);
            label4.TabIndex = 1;
            label4.Text = "الوصف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 3);
            label2.Name = "label2";
            label2.Size = new Size(30, 26);
            label2.TabIndex = 0;
            label2.Text = "SN";
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button10.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(62, 524);
            button10.Name = "button10";
            button10.Size = new Size(44, 47);
            button10.TabIndex = 33;
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(12, 524);
            button9.Name = "button9";
            button9.Size = new Size(44, 47);
            button9.TabIndex = 32;
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtAddress.Location = new Point(13, 606);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(306, 23);
            txtAddress.TabIndex = 31;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPhone.Location = new Point(49, 580);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(85, 23);
            txtPhone.TabIndex = 30;
            // 
            // txtDeliveryTime
            // 
            txtDeliveryTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDeliveryTime.Format = DateTimePickerFormat.Time;
            txtDeliveryTime.Location = new Point(186, 554);
            txtDeliveryTime.Name = "txtDeliveryTime";
            txtDeliveryTime.Size = new Size(134, 23);
            txtDeliveryTime.TabIndex = 29;
            // 
            // cbClient
            // 
            cbClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(186, 580);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(134, 23);
            cbClient.TabIndex = 28;
            // 
            // cbDelivery
            // 
            cbDelivery.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbDelivery.FormattingEnabled = true;
            cbDelivery.Location = new Point(186, 526);
            cbDelivery.Name = "cbDelivery";
            cbDelivery.Size = new Size(134, 23);
            cbDelivery.TabIndex = 27;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(139, 578);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 26;
            label10.Text = "الهاتف";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(355, 603);
            label9.Name = "label9";
            label9.Size = new Size(44, 22);
            label9.TabIndex = 25;
            label9.Text = "العنوان";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(333, 580);
            label8.Name = "label8";
            label8.Size = new Size(66, 22);
            label8.TabIndex = 24;
            label8.Text = "اسم الزبون";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(322, 555);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 23;
            label7.Text = "وقت التوصيل";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 528);
            label6.Name = "label6";
            label6.Size = new Size(77, 22);
            label6.TabIndex = 22;
            label6.Text = "عامل التوصيل";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Janna LT", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(345, 500);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 21;
            label5.Text = "الإجمالي:";
            // 
            // btnCash
            // 
            btnCash.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCash.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCash.Image = (Image)resources.GetObject("btnCash.Image");
            btnCash.ImageAlign = ContentAlignment.MiddleLeft;
            btnCash.Location = new Point(348, 676);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(73, 33);
            btnCash.TabIndex = 20;
            btnCash.Text = "كاش";
            btnCash.TextAlign = ContentAlignment.MiddleLeft;
            btnCash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCash.UseVisualStyleBackColor = true;
            // 
            // btnToAccount
            // 
            btnToAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnToAccount.Font = new Font("Janna LT", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToAccount.Image = (Image)resources.GetObject("btnToAccount.Image");
            btnToAccount.ImageAlign = ContentAlignment.TopCenter;
            btnToAccount.Location = new Point(272, 678);
            btnToAccount.Name = "btnToAccount";
            btnToAccount.Size = new Size(73, 33);
            btnToAccount.TabIndex = 19;
            btnToAccount.Text = "بالحساب";
            btnToAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnToAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToAccount.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(348, 641);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(73, 33);
            btnNew.TabIndex = 18;
            btnNew.Text = "جديد";
            btnNew.TextAlign = ContentAlignment.MiddleLeft;
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(272, 641);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 33);
            btnSave.TabIndex = 17;
            btnSave.Text = "حفظ";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(196, 641);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 33);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "إلغاء";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrint.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(13, 641);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(76, 33);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "طباعة";
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Red;
            lblTotal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(13, 494);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 29);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "0";
            // 
            // txtTime
            // 
            txtTime.Format = DateTimePickerFormat.Time;
            txtTime.ImeMode = ImeMode.Disable;
            txtTime.Location = new Point(12, 66);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(99, 23);
            txtTime.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 65);
            label3.Name = "label3";
            label3.Size = new Size(43, 24);
            label3.TabIndex = 12;
            label3.Text = "الوقت";
            // 
            // txtDate
            // 
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.ImeMode = ImeMode.Disable;
            txtDate.Location = new Point(266, 70);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(99, 23);
            txtDate.TabIndex = 11;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(373, 67);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(40, 24);
            lbDate.TabIndex = 9;
            lbDate.Text = "التاريخ";
            // 
            // lblInvNo
            // 
            lblInvNo.AutoSize = true;
            lblInvNo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvNo.ForeColor = Color.Red;
            lblInvNo.Location = new Point(186, 34);
            lblInvNo.Name = "lblInvNo";
            lblInvNo.Size = new Size(17, 19);
            lblInvNo.TabIndex = 8;
            lblInvNo.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 7;
            label1.Text = "رقم الفاتورة";
            // 
            // btnNext
            // 
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(396, 19);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 42);
            btnNext.TabIndex = 6;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(12, 17);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(39, 42);
            btnPrevious.TabIndex = 5;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sn, dgvID, dgvItemID, dgvItemDescription, dgvQty, dgvPrice, dgvAmount });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Janna LT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(4, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(442, 361);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // Sn
            // 
            Sn.HeaderText = "SN";
            Sn.MinimumWidth = 6;
            Sn.Name = "Sn";
            Sn.Width = 50;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "dgvID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.Visible = false;
            dgvID.Width = 125;
            // 
            // dgvItemID
            // 
            dgvItemID.HeaderText = "dgvItemID";
            dgvItemID.MinimumWidth = 6;
            dgvItemID.Name = "dgvItemID";
            dgvItemID.Visible = false;
            dgvItemID.Width = 20;
            // 
            // dgvItemDescription
            // 
            dgvItemDescription.HeaderText = "dgvItemDescription";
            dgvItemDescription.MinimumWidth = 6;
            dgvItemDescription.Name = "dgvItemDescription";
            dgvItemDescription.Width = 220;
            // 
            // dgvQty
            // 
            dgvQty.HeaderText = "dgvQty";
            dgvQty.MinimumWidth = 20;
            dgvQty.Name = "dgvQty";
            dgvQty.Width = 40;
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "dgvPrice";
            dgvPrice.MinimumWidth = 6;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.Width = 80;
            // 
            // dgvAmount
            // 
            dgvAmount.HeaderText = "dgvAmount";
            dgvAmount.MinimumWidth = 6;
            dgvAmount.Name = "dgvAmount";
            dgvAmount.Width = 80;
            // 
            // FooterPanel
            // 
            FooterPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FooterPanel.Controls.Add(lblSelectedQty);
            FooterPanel.Controls.Add(btnQtyUp);
            FooterPanel.Controls.Add(btnQtyDn);
            FooterPanel.Controls.Add(lblSelectedItem);
            FooterPanel.Controls.Add(btn9);
            FooterPanel.Controls.Add(btn8);
            FooterPanel.Controls.Add(btn7);
            FooterPanel.Controls.Add(btn6);
            FooterPanel.Controls.Add(btn5);
            FooterPanel.Controls.Add(btn4);
            FooterPanel.Controls.Add(btn3);
            FooterPanel.Controls.Add(btn2);
            FooterPanel.Controls.Add(btn1);
            FooterPanel.Location = new Point(0, 719);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(794, 65);
            FooterPanel.TabIndex = 3;
            // 
            // lblSelectedQty
            // 
            lblSelectedQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSelectedQty.AutoSize = true;
            lblSelectedQty.BackColor = SystemColors.Control;
            lblSelectedQty.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedQty.FlatStyle = FlatStyle.Flat;
            lblSelectedQty.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedQty.ForeColor = SystemColors.ControlText;
            lblSelectedQty.Location = new Point(573, 19);
            lblSelectedQty.Name = "lblSelectedQty";
            lblSelectedQty.Size = new Size(28, 37);
            lblSelectedQty.TabIndex = 31;
            lblSelectedQty.Text = "1";
            lblSelectedQty.Click += lblSelectedQty_Click;
            // 
            // btnQtyUp
            // 
            btnQtyUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQtyUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQtyUp.Image = (Image)resources.GetObject("btnQtyUp.Image");
            btnQtyUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnQtyUp.Location = new Point(616, 16);
            btnQtyUp.Name = "btnQtyUp";
            btnQtyUp.Size = new Size(42, 39);
            btnQtyUp.TabIndex = 30;
            btnQtyUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQtyUp.UseVisualStyleBackColor = true;
            btnQtyUp.Click += btnQtyUp_Click;
            // 
            // btnQtyDn
            // 
            btnQtyDn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQtyDn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQtyDn.Image = (Image)resources.GetObject("btnQtyDn.Image");
            btnQtyDn.ImageAlign = ContentAlignment.MiddleLeft;
            btnQtyDn.Location = new Point(526, 14);
            btnQtyDn.Name = "btnQtyDn";
            btnQtyDn.Size = new Size(41, 43);
            btnQtyDn.TabIndex = 29;
            btnQtyDn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQtyDn.UseVisualStyleBackColor = true;
            btnQtyDn.Click += btnQtyDn_Click;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSelectedItem.AutoSize = true;
            lblSelectedItem.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedItem.Location = new Point(674, 26);
            lblSelectedItem.Name = "lblSelectedItem";
            lblSelectedItem.Size = new Size(62, 24);
            lblSelectedItem.TabIndex = 27;
            lblSelectedItem.Text = "selected";
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ImageAlign = ContentAlignment.MiddleLeft;
            btn9.Location = new Point(59, 21);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 33);
            btn9.TabIndex = 26;
            btn9.Text = "9";
            btn9.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ImageAlign = ContentAlignment.MiddleLeft;
            btn8.Location = new Point(108, 21);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 33);
            btn8.TabIndex = 25;
            btn8.Text = "8";
            btn8.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ImageAlign = ContentAlignment.MiddleLeft;
            btn7.Location = new Point(160, 21);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 33);
            btn7.TabIndex = 24;
            btn7.Text = "7";
            btn7.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ImageAlign = ContentAlignment.MiddleLeft;
            btn6.Location = new Point(211, 21);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 33);
            btn6.TabIndex = 23;
            btn6.Text = "6";
            btn6.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ImageAlign = ContentAlignment.MiddleLeft;
            btn5.Location = new Point(262, 21);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 33);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ImageAlign = ContentAlignment.MiddleLeft;
            btn4.Location = new Point(313, 21);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 33);
            btn4.TabIndex = 21;
            btn4.Text = "4";
            btn4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(364, 21);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 33);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(415, 21);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 33);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(466, 21);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 33);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // SalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 791);
            Controls.Add(FooterPanel);
            Controls.Add(InvoicePanel);
            Controls.Add(HeaderPanel);
            Controls.Add(ProductPanel);
            Name = "SalesInvoice";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "git add ";
            Load += SalesInvoice_Load;
            HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            InvoicePanel.ResumeLayout(false);
            InvoicePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            FooterPanel.ResumeLayout(false);
            FooterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel HeaderPanel;
        private Panel InvoicePanel;
        private FlowLayoutPanel ProductPanel;
        private Panel FooterPanel;
        private PictureBox pictureBox1;
        private FlowLayoutPanel CategoryPanel;
        private Button btnPrevious;
        private DataGridView dataGridView1;
        private Button btnNext;
        private Label label1;
        private Label lbDate;
        private Label lblInvNo;
        private DateTimePicker txtDate;
        private Button btnDelete;
        private Button btnPrint;
        private Label lblTotal;
        private DateTimePicker txtTime;
        private Label label3;
        private Button btnCash;
        private Button btnToAccount;
        private Button btnNew;
        private Button btnSave;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button10;
        private Button button9;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker txtDeliveryTime;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btnQtyUp;
        private Button btnQtyDn;
        private Label lblSelectedItem;
        private Label lblSelectedQty;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label4;
        private Label label2;
        public ComboBox cbClient;
        public ComboBox cbDelivery;
        private DataGridViewTextBoxColumn Sn;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvItemID;
        private DataGridViewTextBoxColumn dgvItemDescription;
        private DataGridViewTextBoxColumn dgvQty;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvAmount;
    }
}