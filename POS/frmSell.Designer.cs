namespace POS
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            panel1 = new Panel();
            btnListClient = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAddClient = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
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
            panel1.Controls.Add(btnAddClient);
            panel1.Location = new Point(499, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 137);
            panel1.TabIndex = 9;
            // 
            // btnListClient
            // 
            btnListClient.FlatAppearance.BorderColor = Color.Gainsboro;
            btnListClient.FlatStyle = FlatStyle.Flat;
            btnListClient.Font = new Font("Janna LT", 9.749999F);
            btnListClient.Image = (Image)resources.GetObject("btnListClient.Image");
            btnListClient.ImageAlign = ContentAlignment.MiddleRight;
            btnListClient.Location = new Point(21, 80);
            btnListClient.Name = "btnListClient";
            btnListClient.Size = new Size(102, 32);
            btnListClient.TabIndex = 7;
            btnListClient.Text = "لائحة";
            btnListClient.UseVisualStyleBackColor = true;
            btnListClient.Click += btnListClient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold);
            lblTitle.Location = new Point(8, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "فواتير المبيع";
            // 
            // btnAddClient
            // 
            btnAddClient.FlatAppearance.BorderColor = Color.Gainsboro;
            btnAddClient.FlatStyle = FlatStyle.Flat;
            btnAddClient.Font = new Font("Janna LT", 9.749999F);
            btnAddClient.Image = (Image)resources.GetObject("btnAddClient.Image");
            btnAddClient.ImageAlign = ContentAlignment.MiddleRight;
            btnAddClient.Location = new Point(21, 43);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(102, 32);
            btnAddClient.TabIndex = 4;
            btnAddClient.Text = "إضافة";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(196, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 137);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Janna LT", 9.749999F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(21, 80);
            button1.Name = "button1";
            button1.Size = new Size(102, 32);
            button1.TabIndex = 7;
            button1.Text = "لائحة";
            button1.UseVisualStyleBackColor = true;
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
            label1.Font = new Font("Janna LT", 11.999999F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 5;
            label1.Text = "استهلاك المواد";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Janna LT", 9.749999F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(21, 43);
            button2.Name = "button2";
            button2.Size = new Size(102, 32);
            button2.TabIndex = 4;
            button2.Text = "إضافة";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmSell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSell";
            RightToLeft = RightToLeft.Yes;
            Text = "المبيع";
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
        private Button btnListClient;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAddClient;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button2;
    }
}