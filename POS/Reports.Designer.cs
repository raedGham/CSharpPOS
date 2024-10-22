namespace POS
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblTitle = new Label();
            btnListUser = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2 = new Panel();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            panel3 = new Panel();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnListUser);
            panel1.Location = new Point(714, 83);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 334);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(30, 212);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(240, 43);
            button2.TabIndex = 15;
            button2.Text = "لائحة";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(30, 148);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(240, 43);
            button1.TabIndex = 14;
            button1.Text = "حركة المبيع";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(200, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 45);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "المبيع";
            // 
            // btnListUser
            // 
            btnListUser.FlatStyle = FlatStyle.Flat;
            btnListUser.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListUser.Image = (Image)resources.GetObject("btnListUser.Image");
            btnListUser.ImageAlign = ContentAlignment.MiddleRight;
            btnListUser.Location = new Point(30, 83);
            btnListUser.Margin = new Padding(3, 4, 3, 4);
            btnListUser.Name = "btnListUser";
            btnListUser.Size = new Size(240, 43);
            btnListUser.TabIndex = 13;
            btnListUser.Text = "المبيعات اليومية التفصيلية\r\n";
            btnListUser.TextAlign = ContentAlignment.MiddleLeft;
            btnListUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListUser.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(359, 83);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 334);
            panel2.TabIndex = 16;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(30, 148);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(240, 43);
            button4.TabIndex = 14;
            button4.Text = "أرصدة التجار\r\n";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 45);
            label1.TabIndex = 12;
            label1.Text = "الحسابات";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(30, 83);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(240, 43);
            button5.TabIndex = 13;
            button5.Text = "ارصدة الزبائن";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button8);
            panel3.Location = new Point(14, 83);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 334);
            panel3.TabIndex = 16;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(30, 148);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(240, 43);
            button7.TabIndex = 14;
            button7.Text = "استهلاك البضاعة";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Janna LT", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(160, 16);
            label2.Name = "label2";
            label2.Size = new Size(130, 45);
            label2.TabIndex = 12;
            label2.Text = "المشتريات";
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(30, 83);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(240, 43);
            button8.TabIndex = 13;
            button8.Text = "المشتريات\r\n";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 677);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            RightToLeft = RightToLeft.Yes;
            Text = "التقارير";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnListUser;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button button4;
        private Label label1;
        private Button button5;
        private Panel panel3;
        private Button button7;
        private Label label2;
        private Button button8;
    }
}