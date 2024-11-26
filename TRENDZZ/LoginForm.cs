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

            // Hash the entered password before verifying
            string hashedPassword = DatabaseHelper.ComputeSHA256Hash(password);

            // Verify user credentials from the database using hashed password
            if (dbHelper.VerifyUser(username, hashedPassword, selectedRole)) // Pass selectedRole as a parameter
            {
                MessageBox.Show($"Welcome {username}! Role: {selectedRole}");



                switch (selectedRole)
                {
                    case "Admin":
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        break;

                    case "Journalist":
                        JournalistDashboard journalistDashboard = new JournalistDashboard();
                        journalistDashboard.Show();
                        break;

                    case "User":
                        UserDashboard userDashboard = new UserDashboard();
                        userDashboard.Show();
                        break;
                }

                this.Hide(); // Close the login form


            }
            else
            {
                MessageBox.Show("Invalid credentials or role mismatch. Please try again!");
            }



        }
    }
}
