

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
    public partial class LoginForm : Form
    {
        private string selectedRole; // To store the selected role
        public LoginForm(string role)
        {
            InitializeComponent();
            selectedRole = role; // Store the selected role
        }

        // Optional: Show the selected role on the login form (e.g., as a label)
        private void LoginForm_Load(object sender, EventArgs e)
        {
            roleLable.Text = $"You are logging in as: {selectedRole}"; // Display role
            string userRole = UserSession.Role as string;

            // Conditional logic based on the role
            if (userRole == "Admin")
            {
                Registerlable.Visible = false;  // Hide signup label
                Registerbutton.Visible = false;  // Hide signup button
            }
            else
            {
                Registerlable.Visible = true;  // Show signup label
                Registerbutton.Visible = true;  // Show signup button
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage(selectedRole);
            signupPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Verify user credentials from the database (use your DatabaseHelper here)
            if (dbHelper.VerifyUser(username, password, selectedRole)) // Pass selectedRole as a parameter
            {
                MessageBox.Show($"Welcome {username}! Role: {selectedRole}");

                //Redirect to the respective dashboard based on the role
                //switch (selectedRole)
                //{
                //    case "Admin":
                //        AdminDashboard adminDashboard = new AdminDashboard();
                //        adminDashboard.Show();
                //        break;

                //    case "Journalist":
                //        JournalistDashboard journalistDashboard = new JournalistDashboard();
                //        journalistDashboard.Show();
                //        break;

                //    case "User":
                //        UserDashboard userDashboard = new UserDashboard();
                //        userDashboard.Show();
                //        break;
                //}

                this.Hide(); // Close the login form
            }
            else
            {
                MessageBox.Show("Invalid credentials or role mismatch. Please try again!");
            }

        }
        
    }
}
