using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace TRENDZZ
{
    public partial class SignupPage : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper(); // Instance of DbHelper
        public SignupPage(string userRole)
        {
            InitializeComponent();
            UserSession.Role = userRole;
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            string userRole = UserSession.Role;

            // Show the Company Name field only if the role is Journalist
            if (userRole == "Journalist")
            {
                txtCompanyName.Visible = true;
            }
            else
            {
                txtCompanyName.Visible = false;
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            // Get form input values
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string userRole = UserSession.Role; // Role from session
            string companyName = txtCompanyName.Text.Trim();
            int termsAccepted = chkTerms.Checked ? 1 : 0; // Checkbox for terms

            // **Validation**
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!chkTerms.Checked)
            {
                MessageBox.Show("You must accept the terms and conditions to sign up.", "Terms Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // **Password Hashing**
            string passwordHash = DatabaseHelper.ComputeSHA256Hash(password);

            // **Query**
            string query = "INSERT INTO Users (Username, PasswordHash, Email, Role, CompanyName, TermsAccepted) " +
                           "VALUES (@Username, @PasswordHash, @Email, @Role, @CompanyName, @TermsAccepted)";

            try
            {
                // Use DbHelper instance for database operations
                using (MySqlConnection connection = dbHelper.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", userRole);
                    cmd.Parameters.AddWithValue("@TermsAccepted", termsAccepted);

                    // Include company name only for journalists
                    if (userRole == "Journalist")
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", DBNull.Value);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User registered successfully!");
                    this.Hide();

                    if (userRole == "Journalist")
                    {
                        JournalistDashboard journalistDashboard = new JournalistDashboard();
                        journalistDashboard.Show();
                    }
                    else if (userRole == "User")
                    {
                        UserDashboard userDashboard = new UserDashboard();
                        userDashboard.Show();
                    }
                }
            }
            catch (MySqlException mysqlEx) when (mysqlEx.Number == 1062) // Handle duplicate entry error
            {
                MessageBox.Show("The username or email already exists. Please choose a different one.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}



