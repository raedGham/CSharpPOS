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
            HeaderPanel = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            CategoryPanel = new FlowLayoutPanel();
            ProductPanel = new FlowLayoutPanel();
            InvoicePanel = new Panel();
            FooterPanel = new Panel();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            InvoicePanel.SuspendLayout();
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
            ProductPanel.Size = new Size(908, 649);
            ProductPanel.TabIndex = 1;
            // 
            // InvoicePanel
            // 
            InvoicePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            InvoicePanel.Controls.Add(FooterPanel);
            InvoicePanel.Location = new Point(904, 78);
            InvoicePanel.Name = "InvoicePanel";
            InvoicePanel.Size = new Size(341, 721);
            InvoicePanel.TabIndex = 2;
            InvoicePanel.Paint += InvoicePanel_Paint;
            // 
            // FooterPanel
            // 
            FooterPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FooterPanel.Location = new Point(296, 649);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(949, 72);
            FooterPanel.TabIndex = 3;
            // 
            // SalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 800);
            Controls.Add(InvoicePanel);
            Controls.Add(ProductPanel);
            Controls.Add(HeaderPanel);
            Name = "SalesInvoice";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "SalesInvoice";
            Load += SalesInvoice_Load;
            HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            InvoicePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel HeaderPanel;
        private Panel InvoicePanel;
        private FlowLayoutPanel ProductPanel;
        private Panel FooterPanel;
        private PictureBox pictureBox1;
        private FlowLayoutPanel CategoryPanel;
    }
}