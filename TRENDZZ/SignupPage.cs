using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRENDZZ
{
    public partial class SignupPage : Form

    {
        private SqlConnection connection;
        private string connectionString = "Data Source=localhost;Initial Catalog= TrendzzDB;Integrated Security=True;";

        public SignupPage(string userRole)
        {
            InitializeComponent();
            UserSession.Role = userRole;
            connection = new SqlConnection(connectionString);
        }

        private void Usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            string userRole = UserSession.Role as string;

            // If the role is Journalist, show the Company Name field
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string userRole = UserSession.Role.ToString();  // Get selected role from session
            string companyName = txtCompanyName.Text;  // Company name will be empty for non-Journalists

            // Prepare the SQL command to insert data into the database
            string query = "INSERT INTO Users (Username, Password, Email, Role, CompanyName) VALUES (@Username, @Password, @Email, @Role, @CompanyName)";

            // Use parameterized query to prevent SQL injection
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);  // No password hashing as per your request
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Role", userRole);

            // If the user is a Journalist, include the company name
            if (userRole == "Journalist")
            {
                cmd.Parameters.AddWithValue("@CompanyName", companyName);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CompanyName", DBNull.Value);  // No company name for non-Journalists
            }

            // Execute the query to insert the data into the database
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User registered successfully!");

                // Redirect the user to the appropriate dashboard based on their role
                //if (userRole == "Journalist")
                //{
                //    this.Hide();
                //    JournalistDashboard journalistDashboard = new JournalistDashboard();
                //    journalistDashboard.Show();
                //}
                //else if (userRole == "User")
                //{
                //    this.Hide();
                //    UserDashboard userDashboard = new UserDashboard();
                //    userDashboard.Show();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
