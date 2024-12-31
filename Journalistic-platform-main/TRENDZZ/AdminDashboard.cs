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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.IO;
using OfficeOpenXml; // Install EPPlus NuGet Package




namespace TRENDZZ
{
    public partial class AdminDashboard : Form
    {
        string connectionString = "Server=localhost;Database=trendzzdb;User ID=root;Password=MARIAKHAN123";
        private int userId;



        public AdminDashboard(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId; // Store user ID



        }



        private void LoadUserList()
        {
            panelUserList.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Username, AccountStatus FROM Users WHERE AccountStatus = 'Active' ORDER BY CreatedAt DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    int yPosition = 10;

                    while (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string accountStatus = reader["AccountStatus"].ToString();

                        Label lblUser = new Label
                        {
                            Text = $"{username} - {accountStatus}",
                            Location = new Point(10, yPosition),
                            Size = new Size(200, 30),
                            ForeColor = accountStatus == "Active" ? Color.Green : Color.Red,
                            Tag = username // Store the username for click event
                        };

                        lblUser.Click += UserLabel_Click; // Attach event handler
                        panelUserList.Controls.Add(lblUser);

                        yPosition += 40;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                string username = clickedLabel.Tag.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the role of the user (User/Journalist)
                    string roleQuery = "SELECT Role FROM Users WHERE Username = @Username";
                    MySqlCommand roleCommand = new MySqlCommand(roleQuery, connection);
                    roleCommand.Parameters.AddWithValue("@Username", username);
                    string role = roleCommand.ExecuteScalar()?.ToString();

                    // Prompt for functionality based on the role
                    DialogResult result = MessageBox.Show(
                        role == "Journalist"
                            ? $"What would you like to do for {username}?\n\nClick Yes to View Details.\nClick No to Download the File.\nClick Cancel to Track Profile."
                            : $"Do you want to view or download details for {username}?\n\nClick Yes to View Details.\nClick No to Download the File.",
                        "Choose Action",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        ShowUserDetails(username);
                    }
                    else if (result == DialogResult.No)
                    {
                        DataTable userDetails = FetchUserDetails(username);
                        if (userDetails != null)
                        {
                            SaveUserDetailsToExcel(userDetails, username);
                            MessageBox.Show($"Details for {username} have been downloaded to Excel.");
                        }
                    }
                    else if (result == DialogResult.Cancel && role == "Journalist")
                    {
                        TrackJournalistProfile(username);
                    }
                }
            }
        }

        private void TrackJournalistProfile(string username)
        {
            // Clear existing panel content
            panelUserList.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to fetch journalist's posts and comments
                    string query = @"
            SELECT PostID, Title, Content 
            FROM Posts 
            WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    MySqlDataReader reader = command.ExecuteReader();

                    int yPosition = 10; // Start position for displaying posts

                    while (reader.Read())
                    {
                        int postId = Convert.ToInt32(reader["PostID"]);
                        string title = reader["Title"].ToString();
                        string content = reader["Content"].ToString();

                        // Display post details
                        Label lblPost = new Label
                        {
                            Text = $"Post: {title}\n{content}",
                            Location = new Point(10, yPosition),
                            Size = new Size(400, 60),
                            ForeColor = Color.Black, // Text color
                            Tag = postId
                        };

                        // Add delete button for the post
                        Button btnDeletePost = new Button
                        {
                            Text = "Delete Post",
                            Location = new Point(420, yPosition),
                            Size = new Size(100, 30),
                            Tag = postId
                        };
                        btnDeletePost.Click += (s, e) => DeletePost(postId);

                        panelUserList.Controls.Add(lblPost);
                        panelUserList.Controls.Add(btnDeletePost);

                        yPosition += 80; // Space for next post
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching journalist profile: " + ex.Message);
                }
            }
        }

        private void DeletePost(int postId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to delete the post
                    string query = "DELETE FROM Posts WHERE PostID = @PostID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PostID", postId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Post deleted successfully.");
                        LoadUserList(); // Refresh the user list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete post.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting post: " + ex.Message);
                }
            }
        }


        private void ShowUserDetails(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to fetch user details based on role
                    string query = @"
                SELECT 
                    u.UserID, u.Username, u.Email, u.AccountStatus, u.LastLogin, u.CreatedAt,
                    COUNT(DISTINCT l.LikeID) AS TotalLikes,
                    COUNT(DISTINCT c.CommentID) AS TotalComments,
                    COUNT(DISTINCT p.PostID) AS TotalPosts
                FROM Users u
                LEFT JOIN Likes l ON u.UserID = l.UserID
                LEFT JOIN Comments c ON u.UserID = c.UserID
                LEFT JOIN Posts p ON u.UserID = p.UserID
                WHERE u.Username = @Username
                GROUP BY u.UserID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fetch all the details
                        string details = $@"
                         Username: {reader["Username"]}
                         Email: {reader["Email"]}
                         Account Status: {reader["AccountStatus"]}
                         Registered On: {reader["CreatedAt"]}
                         Last Login: {reader["LastLogin"]}
                         Total Likes: {reader["TotalLikes"]}
                         Total Comments: {reader["TotalComments"]}
                         Total Posts: {reader["TotalPosts"]}";

                        MessageBox.Show(details, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No details found for the selected user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user details: " + ex.Message);
                }
            }
        }



        private DataTable FetchUserDetails(string username)
        {
            DataTable userDetails = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    UserID, Username, Email, AccountStatus, LastLogin, CreatedAt
                FROM Users
                WHERE Username = @Username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(userDetails);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching user details: " + ex.Message);
                }
            }

            return userDetails;
        }


        private void SaveUserDetailsToExcel(DataTable userDetails, string username)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UserDetails");
            Directory.CreateDirectory(folderPath); // Create folder if it doesn't exist
            string filePath = Path.Combine(folderPath, $"{username}_Details.xlsx");

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("User Details");
                worksheet.Cells["A1"].LoadFromDataTable(userDetails, true); // Load data with column headers
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }






        //private void LoadUserList()
        //{
        //    // Ensure panelUserList is clear before adding new labels
        //    panelUserList.Controls.Clear();

        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string query = "SELECT Username, AccountStatus FROM Users WHERE AccountStatus = 'Active' ORDER BY CreatedAt DESC";
        //            MySqlCommand command = new MySqlCommand(query, connection);

        //            MySqlDataReader reader = command.ExecuteReader();
        //            int yPosition = 10; // Start position for labels

        //            while (reader.Read())
        //            {
        //                string username = reader["Username"].ToString();
        //                string accountStatus = reader["AccountStatus"].ToString();

        //                // Create a new label for each user
        //                Label lblUser = new Label();
        //                lblUser.Text = $"{username} - {accountStatus}";
        //                lblUser.Location = new Point(10, yPosition);
        //                lblUser.Size = new Size(200, 30); // Adjust size as needed

        //                // Style the label based on account status
        //                if (accountStatus == "Active")
        //                {
        //                    lblUser.ForeColor = Color.Green;
        //                }
        //                else
        //                {
        //                    lblUser.ForeColor = Color.Red;
        //                }

        //                // Add the label to the panel
        //                panelUserList.Controls.Add(lblUser);
        //                yPosition += 40;  // Adjust the space between labels
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error fetching data: " + ex.Message);
        //        }
        //    }
        //}

        private void LoadUserGraph()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to get the count of active users
                    string activeUsersQuery = "SELECT COUNT(*) FROM Users WHERE AccountStatus = 'Active'";
                    MySqlCommand commandActiveUsers = new MySqlCommand(activeUsersQuery, connection);
                    int activeUsersCount = Convert.ToInt32(commandActiveUsers.ExecuteScalar());

                    // Query to get the total count of users
                    string totalUsersQuery = "SELECT COUNT(*) FROM Users";
                    MySqlCommand commandTotalUsers = new MySqlCommand(totalUsersQuery, connection);
                    int totalUsersCount = Convert.ToInt32(commandTotalUsers.ExecuteScalar());

                    // Clear existing data in both series
                    chartUsers.Series["Active Users"].Points.Clear();
                    chartUsers.Series["Total Users"].Points.Clear();

                    // Add data points to the series
                    chartUsers.Series["Active Users"].Points.AddXY("Users", activeUsersCount); // X: Label, Y: Value
                    chartUsers.Series["Total Users"].Points.AddXY("Users", totalUsersCount);   // X: Label, Y: Value
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user graph: " + ex.Message);
                }
            }
        }

        private void LoadMonthlyUserGraph()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to get monthly user registrations
                    string query = @"
                SELECT 
                    MONTH(CreatedAt) AS Month, 
                    COUNT(*) AS UserCount 
                FROM Users 
                WHERE YEAR(CreatedAt) = YEAR(CURDATE()) 
                GROUP BY MONTH(CreatedAt) 
                ORDER BY MONTH(CreatedAt)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Clear existing data in the series
                    chartMonthlyUsers.Series["Monthly Registrations"].Points.Clear();

                    // Loop through the data
                    while (reader.Read())
                    {
                        int month = Convert.ToInt32(reader["Month"]);
                        int userCount = Convert.ToInt32(reader["UserCount"]);

                        // Debug: Display the data in Output window
                        Console.WriteLine($"Month: {month}, Users: {userCount}");

                        // Add points to the chart
                        chartMonthlyUsers.Series["Monthly Registrations"].Points.AddXY(
                            new DateTime(2024, month, 1).ToString("MMMM"), // X-Axis: Month Name
                            userCount                                         // Y-Axis: User Count
                        );
                    }

                    // Add an average line to the chart
                    AddAverageLine(chartMonthlyUsers, "Monthly Registrations");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading monthly user graph: " + ex.Message);
                }
            }
        }

        private void AddAverageLine(Chart chart, string seriesName)
        {
            // Calculate the average from the existing data points
            double total = 0;
            int count = chart.Series[seriesName].Points.Count;

            foreach (var point in chart.Series[seriesName].Points)
            {
                total += point.YValues[0];
            }

            double average = count > 0 ? total / count : 0;

            // Create a horizontal line for the average
            Series avgLine = new Series("Average")
            {
                ChartType = SeriesChartType.Line,
                BorderDashStyle = ChartDashStyle.Dash,
                Color = Color.Red,
                BorderWidth = 2
            };

            for (int i = 0; i < count; i++)
            {
                avgLine.Points.AddXY(chart.Series[seriesName].Points[i].XValue, average);
            }

            // Add the series to the chart
            chart.Series.Add(avgLine);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Customize appearance of the chart area
            chartMonthlyUsers.ChartAreas[0].AxisX.Title = "Months";
            chartMonthlyUsers.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartMonthlyUsers.ChartAreas[0].AxisY.Title = "Number of Users";
            chartMonthlyUsers.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartMonthlyUsers.ChartAreas[0].BackColor = Color.LightGray;

            // Add gridlines for better readability
            chartMonthlyUsers.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;
            chartMonthlyUsers.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;

            // Customize series points (data markers)
            chartMonthlyUsers.Series["Monthly Registrations"].Color = Color.Blue;
            chartMonthlyUsers.Series["Monthly Registrations"].BorderWidth = 2;
            chartMonthlyUsers.Series["Monthly Registrations"].MarkerStyle = MarkerStyle.Circle;
            chartMonthlyUsers.Series["Monthly Registrations"].MarkerSize = 8;
            chartMonthlyUsers.Series["Monthly Registrations"].MarkerColor = Color.Red;

            // Display values above points
            chartMonthlyUsers.Series["Monthly Registrations"].IsValueShownAsLabel = true;
            chartMonthlyUsers.Series["Monthly Registrations"].LabelForeColor = Color.Black;

            // Optionally, add a chart title
            chartMonthlyUsers.Titles.Clear(); // Clear any existing titles
            chartMonthlyUsers.Titles.Add("Monthly User Registrations");
            chartMonthlyUsers.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            chartMonthlyUsers.Titles[0].ForeColor = Color.Black;
            LoadUserList();
            LoadUserGraph(); // Call to load the graph
            LoadMonthlyUserGraph();    // Second graph

        }
        
        private void panelHome_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

 