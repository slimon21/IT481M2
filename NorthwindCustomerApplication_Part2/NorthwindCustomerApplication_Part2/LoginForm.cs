using System;
using System.Windows.Forms;

namespace NorthwindCustomerApp
{
    public partial class LoginForm : Form
    {
        public string Server => txtServer.Text;
        public string Database => txtDatabase.Text;
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
