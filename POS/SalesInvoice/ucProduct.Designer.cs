namespace POS.SalesInvoice
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtImage = new PictureBox();
            panel1 = new Panel();
            lblPName = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FloralWhite;
            flowLayoutPanel1.Controls.Add(txtImage);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(-2, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(152, 150);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // txtImage
            // 
            txtImage.Image = (Image)resources.GetObject("txtImage.Image");
            txtImage.Location = new Point(3, 3);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(146, 98);
            txtImage.SizeMode = PictureBoxSizeMode.CenterImage;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPName);
            panel1.Location = new Point(3, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 40);
            panel1.TabIndex = 1;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPName.Location = new Point(44, 7);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(46, 24);
            lblPName.TabIndex = 0;
            lblPName.Text = "label1";
            // 
            // ucProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.Black;
            Name = "ucProduct";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox txtImage;
        private Panel panel1;
        private Label lblPName;
    }
}
