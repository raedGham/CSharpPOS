namespace POS.Menu
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnReports = new Button();
            btnBuy = new Button();
            btnSell = new Button();
            btnFiles = new Button();
            btnAccounts = new Button();
            panelLogo = new Panel();
            btnSettings = new Button();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateBlue;
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnBuy);
            panelMenu.Controls.Add(btnSell);
            panelMenu.Controls.Add(btnFiles);
            panelMenu.Controls.Add(btnAccounts);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(202, 599);
            panelMenu.TabIndex = 3;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnReports.ForeColor = Color.Gainsboro;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(-2, 336);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(0, 0, 7, 0);
            btnReports.Size = new Size(202, 55);
            btnReports.TabIndex = 11;
            btnReports.Text = "      التقارير";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnBuy
            // 
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuy.ForeColor = Color.Gainsboro;
            btnBuy.Image = (Image)resources.GetObject("btnBuy.Image");
            btnBuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuy.Location = new Point(0, 211);
            btnBuy.Name = "btnBuy";
            btnBuy.Padding = new Padding(0, 0, 7, 0);
            btnBuy.Size = new Size(202, 55);
            btnBuy.TabIndex = 10;
            btnBuy.Text = "      الشراء";
            btnBuy.TextAlign = ContentAlignment.MiddleLeft;
            btnBuy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnSell
            // 
            btnSell.FlatAppearance.BorderSize = 0;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSell.ForeColor = Color.Gainsboro;
            btnSell.Image = (Image)resources.GetObject("btnSell.Image");
            btnSell.ImageAlign = ContentAlignment.MiddleLeft;
            btnSell.Location = new Point(0, 152);
            btnSell.Name = "btnSell";
            btnSell.Padding = new Padding(0, 0, 7, 0);
            btnSell.Size = new Size(202, 55);
            btnSell.TabIndex = 9;
            btnSell.Text = "      المبيع";
            btnSell.TextAlign = ContentAlignment.MiddleLeft;
            btnSell.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // btnFiles
            // 
            btnFiles.FlatAppearance.BorderSize = 0;
            btnFiles.FlatStyle = FlatStyle.Flat;
            btnFiles.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiles.ForeColor = Color.Gainsboro;
            btnFiles.Image = (Image)resources.GetObject("btnFiles.Image");
            btnFiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiles.Location = new Point(0, 91);
            btnFiles.Name = "btnFiles";
            btnFiles.Padding = new Padding(0, 0, 7, 0);
            btnFiles.Size = new Size(202, 55);
            btnFiles.TabIndex = 8;
            btnFiles.Text = "      الملفات";
            btnFiles.TextAlign = ContentAlignment.MiddleLeft;
            btnFiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiles.UseVisualStyleBackColor = true;
            btnFiles.Click += btnFiles_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccounts.ForeColor = Color.Gainsboro;
            btnAccounts.Image = (Image)resources.GetObject("btnAccounts.Image");
            btnAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccounts.Location = new Point(0, 272);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Padding = new Padding(0, 0, 7, 0);
            btnAccounts.Size = new Size(202, 55);
            btnAccounts.TabIndex = 7;
            btnAccounts.Text = "      الحسابات";
            btnAccounts.TextAlign = ContentAlignment.MiddleLeft;
            btnAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkSlateBlue;
            panelLogo.Location = new Point(0, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 82);
            panelLogo.TabIndex = 6;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Janna LT", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 397);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(0, 0, 7, 0);
            btnSettings.Size = new Size(202, 55);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "      الاعدادات";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.BackColor = Color.DarkSlateBlue;
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Location = new Point(202, -1);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(874, 85);
            panelTitleBar.TabIndex = 4;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(31, 26);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(32, 32);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Janna LT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(688, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لوحة التحكم";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelDesktopPane.Location = new Point(202, 83);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(874, 504);
            panelDesktopPane.TabIndex = 5;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 599);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FormMainMenu";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnSettings;
        private Panel panelTitleBar;
        private Panel panelLogo;
        private Button btnReports;
        private Button btnBuy;
        private Button btnSell;
        private Button btnFiles;
        private Button btnAccounts;
        private Label lblTitle;
        private Button btnCloseChildForm;
        private Panel panelDesktopPane;
    }
}