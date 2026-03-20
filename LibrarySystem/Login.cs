using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}