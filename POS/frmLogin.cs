namespace POS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValiduser(txtUser.Text, txtPassword.Text) == false)
            {
                MessageBox.Show("Invalid username or Password");
                return;

            }

            else
            {
                this.Hide();
                Menu.FormMainMenu frm = new Menu.FormMainMenu();
                frm.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
