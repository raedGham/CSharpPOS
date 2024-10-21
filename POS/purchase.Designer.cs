namespace POS
{
    partial class purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            panel1 = new Panel();
            btnListInv = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAddInv = new Button();
            panel2 = new Panel();
            btnListConsump = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnAddConsump = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnListInv);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnAddInv);
            panel1.Location = new Point(508, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 137);
            panel1.TabIndex = 8;
            // 
            // btnListInv
            // 
            btnListInv.FlatStyle = FlatStyle.Flat;
            btnListInv.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListInv.Image = (Image)resources.GetObject("btnListInv.Image");
            btnListInv.ImageAlign = ContentAlignment.MiddleRight;
            btnListInv.Location = new Point(21, 80);
            btnListInv.Name = "btnListInv";
            btnListInv.Size = new Size(102, 32);
            btnListInv.TabIndex = 7;
            btnListInv.Text = "لائحة";
            btnListInv.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(9, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "فواتير الشراء";
            // 
            // btnAddInv
            // 
            btnAddInv.FlatStyle = FlatStyle.Flat;
            btnAddInv.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddInv.Image = (Image)resources.GetObject("btnAddInv.Image");
            btnAddInv.ImageAlign = ContentAlignment.MiddleRight;
            btnAddInv.Location = new Point(21, 43);
            btnAddInv.Name = "btnAddInv";
            btnAddInv.Size = new Size(102, 32);
            btnAddInv.TabIndex = 4;
            btnAddInv.Text = "إضافة";
            btnAddInv.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnListConsump);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAddConsump);
            panel2.Location = new Point(222, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 137);
            panel2.TabIndex = 9;
            // 
            // btnListConsump
            // 
            btnListConsump.FlatStyle = FlatStyle.Flat;
            btnListConsump.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListConsump.Image = (Image)resources.GetObject("btnListConsump.Image");
            btnListConsump.ImageAlign = ContentAlignment.MiddleRight;
            btnListConsump.Location = new Point(21, 80);
            btnListConsump.Name = "btnListConsump";
            btnListConsump.Size = new Size(102, 32);
            btnListConsump.TabIndex = 7;
            btnListConsump.Text = "لائحة";
            btnListConsump.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 5);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 5;
            label1.Text = "استهلاك المواد";
            // 
            // btnAddConsump
            // 
            btnAddConsump.FlatStyle = FlatStyle.Flat;
            btnAddConsump.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddConsump.Image = (Image)resources.GetObject("btnAddConsump.Image");
            btnAddConsump.ImageAlign = ContentAlignment.MiddleRight;
            btnAddConsump.Location = new Point(21, 43);
            btnAddConsump.Name = "btnAddConsump";
            btnAddConsump.Size = new Size(102, 32);
            btnAddConsump.TabIndex = 4;
            btnAddConsump.Text = "إضافة";
            btnAddConsump.UseVisualStyleBackColor = true;
            // 
            // purchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "purchase";
            RightToLeft = RightToLeft.Yes;
            Text = "purchase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnListInv;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAddInv;
        private Panel panel2;
        private Button btnListConsump;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnAddConsump;
    }
}