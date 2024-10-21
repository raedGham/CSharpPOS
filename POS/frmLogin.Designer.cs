namespace POS
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 183);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(118, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(179, 17);
            label3.TabIndex = 0;
            label3.Text = "Please enter user information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 219);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(55, 249);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(209, 25);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(58, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(209, 25);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 302);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(55, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(180, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 469);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
