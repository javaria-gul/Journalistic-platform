using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TRENDZZ
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=TrendzzDB;User ID=root;Password= MARIAKHAN123;";


        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public static string ComputeSHA256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public int GetUserId(string username, string hashedPassword, string role)
        {
            int userId = -1; // Default invalid ID

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT UserID FROM users WHERE Username = @Username AND PasswordHash = @Password AND Role = @Role";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                object result = cmd.ExecuteScalar(); // Fetch UserID

                if (result != null) // If valid user
                {
                    userId = Convert.ToInt32(result);
                }

                conn.Close();
            }

            return userId; // Return User ID or -1 if invalid
        }




        public string ValidateUser(string username, string password)
        {
            string role = null; 

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open(); // Open database connection
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND PasswordHash = @password AND Role = @role";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Use parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Hash password if needed

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows) // If a matching user is found
                        {
                            reader.Read(); // Read the first row
                            role = reader["Role"].ToString(); // Get the role of the user
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error for debugging
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return role; // Return the role (null if no match is found)
        }
        public bool VerifyUser(string username, string password, string role)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE " +
                           "LOWER(Username) = LOWER(@username) AND " +
                           "PasswordHash = @password AND " +
                           "LOWER(Role) = LOWER(@role)";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                        return userCount > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

    }

}

