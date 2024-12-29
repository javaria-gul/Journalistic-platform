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
        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            roleLable.Text = $"You are logging in as: {selectedRole}"; // Display role
            if (selectedRole == "Admin")
            {
                Registerlable.Visible = false;  // Hide the label
                Registerbutton.Visible = false;  // Hide the button
                // Alternatively:
                //Registerbutton.Enabled = false;
                //MessageBox.Show("Admins are already registered. No need to sign up again.");
            }
            else
            {
                Registerlable.Visible = true;  // Show the label for users and journalists
                Registerbutton.Visible = true;  // Show the button for users and journalists
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

            // Hash the entered password
            string hashedPassword = DatabaseHelper.ComputeSHA256Hash(password);

            // Verify user credentials and get User ID and Role
            int userId = dbHelper.GetUserId(username, hashedPassword, selectedRole);

            if (userId != -1) // -1 means invalid credentials
            {
                MessageBox.Show($"Welcome {username}! Role: {selectedRole}");

                // Open the respective dashboard based on role
                switch (selectedRole)
                {
                    case "Admin":
                        AdminDashboard adminDashboard = new AdminDashboard(userId); // Pass User ID
                        adminDashboard.Show();
                        break;

                    case "Journalist":
                        JournalistDashboard journalistDashboard = new JournalistDashboard(userId); // Pass User ID
                        journalistDashboard.Show();
                        break;

                    case "User":
                        UserDashboard userDashboard = new UserDashboard(userId); // Pass User ID
                        userDashboard.Show();
                        break;
                }

                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid credentials or role mismatch. Please try again!");
            }
        }

    }
}
