namespace POS
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            panel1 = new Panel();
            btnListClient = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel2 = new Panel();
            btnListSupplier = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnListClient);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(489, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 137);
            panel1.TabIndex = 7;
            // 
            // btnListClient
            // 
            btnListClient.FlatStyle = FlatStyle.Flat;
            btnListClient.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListClient.Image = (Image)resources.GetObject("btnListClient.Image");
            btnListClient.ImageAlign = ContentAlignment.MiddleRight;
            btnListClient.Location = new Point(21, 56);
            btnListClient.Name = "btnListClient";
            btnListClient.Size = new Size(102, 32);
            btnListClient.TabIndex = 7;
            btnListClient.Text = "لائحة";
            btnListClient.UseVisualStyleBackColor = true;
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
            lblTitle.Location = new Point(3, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "حسابات الزبائن";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnListSupplier);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(208, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 137);
            panel2.TabIndex = 8;
            // 
            // btnListSupplier
            // 
            btnListSupplier.FlatStyle = FlatStyle.Flat;
            btnListSupplier.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListSupplier.Image = (Image)resources.GetObject("btnListSupplier.Image");
            btnListSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnListSupplier.Location = new Point(21, 56);
            btnListSupplier.Name = "btnListSupplier";
            btnListSupplier.Size = new Size(102, 32);
            btnListSupplier.TabIndex = 7;
            btnListSupplier.Text = "لائحة";
            btnListSupplier.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 5);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 5;
            label1.Text = "حسابات التجار";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 223);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Accounts";
            Text = "Accounts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnListClient;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Panel panel2;
        private Button btnListSupplier;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}