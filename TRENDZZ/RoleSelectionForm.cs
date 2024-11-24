using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRENDZZ
{
    public partial class RoleSelectionForm : Form
    {
        public RoleSelectionForm()
        {
            InitializeComponent();
        }

        private void RoleSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            UserSession.Role= "Admin";
            LoginForm loginForm = new LoginForm("Admin"); // Pass "Admin" as the role
            loginForm.Show(); // Show the Login Page
            this.Hide(); // Hide the Role Selection Form
        }

        private void JournalistButton_clicked(object sender, EventArgs e)
        {
            UserSession.Role= "Journalist";
            LoginForm loginForm = new LoginForm("Journalist"); // Pass "Journalist" as the role
            loginForm.Show();
            this.Hide();
        }

        private void UserButton_clicked(object sender, EventArgs e)
        {
            UserSession.Role = "User";
            LoginForm loginForm = new LoginForm("User"); // Pass "User" as the role
            loginForm.Show();
            this.Hide();
        }
    }
}
