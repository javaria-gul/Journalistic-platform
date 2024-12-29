using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TRENDZZ
{
    public partial class JournalistDashboard : Form
    {
        // Database Connection String
        private string connectionString = "Server=localhost;Database=TrendzzDB;User ID=root;Password=Mysqlpassword123...;";
        

        // User ID - Replace this with the actual logged-in user ID later
        private readonly int userId; // Reserved for future use
        private string selectedImage = string.Empty; // Stores the selected image path



        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private Stack<Panel> panelHistory = new Stack<Panel>();

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

        public JournalistDashboard(int loggedInUserId)
        {
            InitializeComponent();

            userId = loggedInUserId; // Store user ID
            ShowPanel(pnlHome);

            flpPosts = new FlowLayoutPanel
            {
                AutoScroll = true,
                Size = new Size(660, 400),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };
            pnlHome.Controls.Add(flpPosts);
            SetupHomePanel();
            LoadHomeFeed();
            SetupSearchPanel();            // For Search Panel
            SetupNotificationsPanel();     // For Notifications Panel
            SetupHomePanel();


          

            pbHome.MouseEnter += Icon_MouseEnter;
            pbHome.MouseLeave += Icon_MouseLeave;

            pbHeart.MouseEnter += Icon_MouseEnter;
            pbHeart.MouseLeave += Icon_MouseLeave;

            pbSearch.MouseEnter += Icon_MouseEnter;
            pbSearch.MouseLeave += Icon_MouseLeave;

            pbAdd.MouseEnter += Icon_MouseEnter;
            pbAdd.MouseLeave += Icon_MouseLeave;

            pbProfile.MouseEnter += Icon_MouseEnter;
            pbProfile.MouseLeave += Icon_MouseLeave;

            pbBack.MouseEnter += Icon_MouseEnter;
            pbBack.MouseLeave += Icon_MouseLeave;

            pbCameraIcon.MouseEnter += Icon_MouseEnter;
            pbCameraIcon.MouseLeave += Icon_MouseLeave;

            pbSettingsIcon.MouseEnter += Icon_MouseEnter;
            pbSettingsIcon.MouseLeave += Icon_MouseLeave;

            btnChangeUsername.MouseEnter += Icon_MouseEnter;
            btnChangeUsername.MouseLeave += Icon_MouseLeave;

            btnChangePassword.MouseEnter += Icon_MouseEnter;
            btnChangePassword.MouseLeave += Icon_MouseLeave;

            btnChangeNameBio.MouseEnter += Icon_MouseEnter;
            btnChangeNameBio.MouseLeave += Icon_MouseLeave;

            btnLogout.MouseEnter += Icon_MouseEnter;
            btnLogout.MouseLeave += Icon_MouseLeave;

            pbSettingsIcon.Click += pbSettingsIcon_Click;

            btnPublishPost.Click += btnPublishPost_Click;
            btnSaveDraft.Click += (s, e) => MessageBox.Show("Draft saved! (Placeholder)"); // Draft logic placeholder

            // Load Home Feed on Startup

            // Ensure the FlowLayoutPanel is assigned correctly in the form's initialization
            flpPosts = new FlowLayoutPanel();
            // Alternatively, if it’s already part of the form, ensure it's initialized in the designer file:
            // InitializeComponent();  // This is usually done automatically


            btnChangeUsername.Click += (s, e) => CreateUsernamePanel();
            btnChangePassword.Click += (s, e) => CreatePasswordPanel();
            btnChangeNameBio.Click += (s, e) => CreateNameBioPanel();
            btnLogout.Click += btnLogout_Click;


        }

        // =========================
        // SEARCH PANEL SETUP
        // =========================
        private void SetupSearchPanel()
        {
            TextBox txtSearch = new TextBox
            {
                Width = 500,
                Height = 30,
                Location = new Point(20, 20),
                Font = new Font("Arial", 10),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.Gray,
                Text = "Search..." // Placeholder text
            };

            // Add Focus Events for Placeholder Effect
            txtSearch.GotFocus += (sender, e) =>
            {
                if (txtSearch.Text == "Search...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };

            txtSearch.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };



            Button btnSearch = new Button
            {
                Text = "Search",
                Width = 100,
                Height = 30,
                Location = new Point(530, 20),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSearch.FlatAppearance.BorderSize = 0; // No border

            FlowLayoutPanel flpSearchResults = new FlowLayoutPanel
            {
                AutoScroll = true,
                Size = new Size(660, 400),
                Location = new Point(20, 70),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Add to pnlSearch
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(flpSearchResults);
        }

        private void SetupNotificationsPanel()
        {
            // Notification List
            FlowLayoutPanel flpNotifications = new FlowLayoutPanel
            {
                AutoScroll = true,
                Size = new Size(660, 400),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Example Notification (Dynamic later)
            Panel notificationCard = new Panel
            {
                Size = new Size(620, 50),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lblNotification = new Label
            {
                Text = "User123 liked your post!",
                AutoSize = true,
                Location = new Point(10, 15),
                Font = new Font("Arial", 10)
            };

            notificationCard.Controls.Add(lblNotification);
            flpNotifications.Controls.Add(notificationCard);

            // Add to pnlNotifications
            pnlNotifications.Controls.Add(flpNotifications);
        }

        private void SetupHomePanel()
        {
            // Post Feed
            FlowLayoutPanel flpPosts = new FlowLayoutPanel
            {
                AutoScroll = true,
                Size = new Size(660, 400),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Example Post (Dynamic later)
            Panel postCard = new Panel
            {
                Size = new Size(620, 200),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lblTitle = new Label
            {
                Text = "Post Title Example",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10)
            };

            Label lblContent = new Label
            {
                Text = "This is an example post content. It can be multiple lines.",
                Size = new Size(600, 60),
                Location = new Point(10, 40),
                AutoSize = false
            };

            PictureBox pbPostImage = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(10, 110),
                BackColor = Color.LightGray, // Placeholder for images
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Button btnLike = new Button
            {
                Text = "Like",
                Location = new Point(120, 150),
                Size = new Size(70, 30),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            Button btnComment = new Button
            {
                Text = "Comment",
                Location = new Point(200, 150),
                Size = new Size(80, 30),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            flpPosts = new FlowLayoutPanel
            {
                AutoScroll = true,
                Size = new Size(660, 400),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };
          



            // Add to postCard
            postCard.Controls.Add(lblTitle);
            postCard.Controls.Add(lblContent);
            postCard.Controls.Add(pbPostImage);
            postCard.Controls.Add(btnLike);
            postCard.Controls.Add(btnComment);

            flpPosts.Controls.Add(postCard);
            pnlHome.Controls.Add(flpPosts);
        }



       




        private void MakeCircularPictureBox(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);
        }


        private void LoadProfileData()
        {
            using (MySqlConnection conn = GetConnection())
            {
                // Query to load user profile data
                string query = @"
            SELECT Username, Bio, ProfilePicture, 
            (SELECT COUNT(*) FROM followers WHERE FollowedUserID = @UserID) AS FollowersCount,
            (SELECT COUNT(*) FROM followers WHERE UserID = @UserID) AS FollowingCount,
            (SELECT COUNT(*) FROM posts WHERE UserID = @UserID AND IsDraft = 0) AS ArticlesCount
            FROM users WHERE UserID = @UserID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Load name and bio
                    lblName.Text = reader["Username"].ToString();
                    txtBio.Text = reader["Bio"].ToString();

                    // Load stats
                    lblFollowers.Text = reader["FollowersCount"].ToString() + " Followers";
                    lblFollowing.Text = reader["FollowingCount"].ToString() + " Following";
                    lblPosts.Text = reader["ArticlesCount"].ToString() + " Posts";

                    // Load profile picture
                    string profilePicturePath = reader["ProfilePicture"].ToString();
                    if (!string.IsNullOrEmpty(profilePicturePath) && File.Exists(profilePicturePath))
                    {
                        pbProfilePic.Image = Image.FromFile(profilePicturePath); // Load image from file
                    }
                    else
                    {
                        pbProfilePic.Image = Properties.Resources.defaultProfilePic; // Default image
                    }
                }

                conn.Close();
            }
        }

        private void UpdatePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                // Display the new image
                pbProfilePic.Image = Image.FromFile(selectedFilePath);

                // Save image path to database
                using (MySqlConnection conn = GetConnection())
                {
                    string query = "UPDATE users SET ProfilePicture = @PicturePath WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PicturePath", selectedFilePath); // Save file path
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Profile Picture Updated!");
                }
            }
        }

        private void DeletePicture_Click(object sender, EventArgs e)
        {
            pbProfilePic.Image = Properties.Resources.defaultProfilePic;

            // Remove image path from database
            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE users SET ProfilePicture = NULL WHERE UserID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Profile Picture Removed!");
            }
        }



        private void ShowPanel(Panel panel)
        {
            // Hide all panels
            pnlHome.Visible = false;
            pnlNotifications.Visible = false;
            pnlSearch.Visible = false;
            pnlAddPost.Visible = false;
            pnlProfile.Visible = false;
            pnlSettings.Visible = false;

            // Show the requested panel
            panel.Visible = true;
            panel.BringToFront(); // Ensure it's at the top
        

            if (panelHistory.Count == 0 || panelHistory.Peek() != panel)
            {
                panelHistory.Push(panel);
            }
        }
        // Hover Effects - Highlight Icon on Mouse Enter
        private void Icon_MouseEnter(object sender, EventArgs e)
        {
            PictureBox icon = sender as PictureBox;

            if (icon == pbCameraIcon) // Small Hover for Camera Icon
            {
                icon.Size = new Size(50, 50); // Smaller size
                icon.BackColor = Color.Transparent;
            }
            else if (icon == pbSettingsIcon) // Larger Hover for Settings Icon
            {
                icon.Size = new Size(100, 100); // Bigger size
                icon.BackColor = Color.LightGray;
            }
            else if (sender is Button button) // For Button controls
            {
                button.Size = new Size(270, 55); // Example hover size for buttons
            }
            

            else // Default Hover Size for Sidebar Icons
            {
                icon.Size = new Size(80, 80); // Same size for other icons
                icon.BackColor = Color.LightGray;
            }
        }

        // Reset Icon on Mouse Leave
        private void Icon_MouseLeave(object sender, EventArgs e)
        {
            PictureBox icon = sender as PictureBox;

            if (icon == pbCameraIcon) // Reset Camera Icon Size
            {
                icon.Size = new Size(40, 40); // Original size for Camera
                icon.BackColor = Color.Transparent;
            }
            else if (icon == pbSettingsIcon) // Reset Settings Icon Size
            {
                icon.Size = new Size(90, 90); // Original size for Settings
                icon.BackColor = Color.Transparent;
            }

            else if (sender is Button button) // For Button controls
            {
                button.Size = new Size(262, 47); // Example hover size for buttons
            }
           
            else // Reset Default Size for Sidebar Icons
            {
                icon.Size = new Size(70, 70); // Original size for sidebar
                icon.BackColor = Color.Transparent;
            }

            
        }


        private void JournalistDashboard_Load(object sender, EventArgs e)
        {
            MakeCircularPictureBox(pbProfilePic);
        }

        // Dynamically Create Panels for Settings Options
        private Panel CreateDynamicPanel(string panelName)
        {
            Panel panel = new Panel
            {
                Name = panelName,
                Size = new Size(500, 400), // Larger panel size
                BackColor = Color.DimGray, // Add background color for better visibility
                BorderStyle = BorderStyle.FixedSingle
            };

            // Add a styled back button at the bottom center
            Button btnBack = new Button
            {
                Text = "Back",
                Location = new Point((panel.Width - 100) / 2, panel.Height - 50), // Center the button horizontally
                Size = new Size(100, 30),
                BackColor = Color.Yellow,
                ForeColor = Color.Black

            };
            btnBack.Click += (s, e) =>
            {
                panel.Visible = false; // Hide current panel
                pnlSettings.Visible = true; // Show pnlSettings again
            };

            panel.Controls.Add(btnBack); // Add back button to panel
            return panel;
        }


        private void CreateUsernamePanel()
        {
            Panel pnlUsername = CreateDynamicPanel("pnlUsername");

            Label lblNewUsername = new Label
            {
                Text = "New Username:",
                Font = new Font("Arial", 12),
                AutoSize = true,
                Location = new Point(20, 50)
            };

            TextBox txtNewUsername = new TextBox
            {
                Name = "txtNewUsername",
                Location = new Point(150, 50),
                Width = 300
            };

            Button btnSaveUsername = new Button
            {
                Text = "Save",
                Location = new Point(200, 150), // Centered on panel
                Size = new Size(100, 30),
                BackColor = Color. Yellow,
                ForeColor = Color.Black,
            };
            btnSaveUsername.Click += (s, e) =>
            {
                // Save to database logic
                string newUsername = txtNewUsername.Text;

                using (MySqlConnection conn = GetConnection())
                {
                    string query = "UPDATE users SET Username = @Username WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", newUsername);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Username updated successfully!");
                    pnlUsername.Visible = false;
                    pnlSettings.Visible = true;
                }
            };

            pnlUsername.Controls.Add(lblNewUsername);
            pnlUsername.Controls.Add(txtNewUsername);
            pnlUsername.Controls.Add(btnSaveUsername);

            pnlSettings.Controls.Add(pnlUsername); // Add to profile panel
            pnlUsername.BringToFront();
            pnlUsername.Location = new Point(
                (pnlSettings.Width - pnlUsername.Width) / 2,
                (pnlSettings.Height - pnlUsername.Height) / 2
            );
            pnlUsername.Visible = true;
        }


        private void CreatePasswordPanel()
        {
            Panel pnlPassword = CreateDynamicPanel("pnlPassword");

            Label lblPassword = new Label
            {
                Text = "New Password:",
                Location = new Point(10, 50),
                AutoSize = true
            };

            TextBox txtPassword = new TextBox
            {
                Name = "txtPassword",
                Location = new Point(150, 50),
                Width = 300,
                PasswordChar = '*'
            };

            Label lblConfirm = new Label
            {
                Text = "Confirm Password:",
                Location = new Point(10, 90),
                AutoSize = true
            };

            TextBox txtConfirm = new TextBox
            {
                Name = "txtConfirmPassword",
                Location = new Point(150, 90),
                Width = 300,
                PasswordChar = '*'
            };

            Button btnSavePassword = new Button
            {
                Text = "Save",
                Location = new Point(200, 150), // Centered on panel
                Size = new Size(100, 40),
                AutoSize = true,
                BackColor = Color.Yellow,
                ForeColor = Color.Black
            };

            btnSavePassword.Click += (s, e) =>
            {
                // Validate Passwords
                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                // Hash the new password
                string hashedPassword = ComputeSHA256Hash(txtPassword.Text);

                using (MySqlConnection conn = GetConnection())
                {
                    string query = "UPDATE users SET PasswordHash = @PasswordHash WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Password updated successfully!");
                    pnlPassword.Visible = false;
                    pnlSettings.Visible = true;
                    
                }
            };

            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Controls.Add(lblConfirm);
            pnlPassword.Controls.Add(txtConfirm);
            pnlPassword.Controls.Add(btnSavePassword);

            pnlSettings.Controls.Add(pnlPassword); // Add to profile panel
            pnlPassword.BringToFront();
            pnlPassword.Location = new Point(
                (pnlSettings.Width - pnlPassword.Width) / 2,
                (pnlSettings.Height - pnlPassword.Height) / 2
            );
            pnlPassword.Visible = true;
        }



        private void CreateNameBioPanel()
        {
            Panel pnlNameBio = CreateDynamicPanel("pnlNameBio");

            Label lblName = new Label
            {
                Text = "Name:",
                Location = new Point(10, 50),
                AutoSize = true,
            };

            TextBox txtName = new TextBox
            {
                Name = "txtName",
                Location = new Point(120, 50),
                Width = 300
            };

            Label lblBio = new Label
            {
                Text = "Bio:",
                Location = new Point(10, 90),
                AutoSize = true
            };

            TextBox txtBio = new TextBox
            {
                Name = "txtBio",
                Location = new Point(120, 90),
                Width = 300,
                Multiline = true,
                Height = 60
            };

            Button btnSave = new Button
            {
                Text = "Save",
                Location = new Point(200, 150), // Centered on panel
                Size = new Size(100, 40),
                AutoSize = true,
                BackColor = Color.Yellow,
                ForeColor = Color.Black
            };
            btnSave.Click += (s, e) =>
            {
                using (MySqlConnection conn = GetConnection())

                {
                    string query = "UPDATE users SET Username = @Name, Bio = @Bio WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Bio", txtBio.Text);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Name and Bio updated successfully!");
                    pnlNameBio.Visible = false;
                    pnlSettings.Visible = true;
                }
            };

            pnlNameBio.Controls.Add(lblName);
            pnlNameBio.Controls.Add(txtName);
            pnlNameBio.Controls.Add(lblBio);
            pnlNameBio.Controls.Add(txtBio);
            pnlNameBio.Controls.Add(btnSave);

            pnlSettings.Controls.Add(pnlNameBio); // Add to profile panel
            pnlNameBio.BringToFront();
            pnlNameBio.Location = new Point(
                (pnlSettings.Width - pnlNameBio.Width) / 2,
                (pnlSettings.Height - pnlNameBio.Height) / 2
            );
            pnlNameBio.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm Logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Hide this form and show login form
                this.Hide();
                RoleSelectionForm form = new RoleSelectionForm(); // Replace 'LoginForm' with your login form name
                form.Show(); // Display Login Form
            }
        }






        private void pbHome_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Home button clicked");
            ShowPanel(pnlHome);


        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Search button clicked");
            ShowPanel(pnlSearch);
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add Post button clicked");
            ShowPanel(pnlAddPost);
        }

        private void pbHeart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Notifications button clicked");
            ShowPanel(pnlNotifications);
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlProfile); // Switch to Profile Panel
            LoadProfileData();


        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (panelHistory.Count > 1)
            {
                // Remove current panel
                panelHistory.Pop();

                // Show previous panel
                Panel previousPanel = panelHistory.Peek();
                ShowPanel(previousPanel);
            }
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {

        }

        private void lblFollowing_Click(object sender, EventArgs e)
        {

        }

        private void pbSettingsIcon_Click(object sender, EventArgs e)
        {
            // Ensure pnlSettings is added to the FORM, not pnlProfile
            if (!this.Controls.Contains(pnlSettings)) // Add to form if not added yet
            {
                this.Controls.Add(pnlSettings); // Add pnlSettings directly to FORM, not pnlProfile

                // Set size and position - Responsive
               
                pnlSettings.Location = new Point(
                    (this.Width - pnlSettings.Width) / 2,  // Center horizontally
                    (this.Height - pnlSettings.Height) / 2 // Center vertically
                );
            }

            pnlSettings.Show(); // Simply show the panel
            pnlSettings.BringToFront(); // Ensure it appears on top
        }

        private void btnPublishPost_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            string imagePath = pbPostImage.ImageLocation; // Optional image path

            // Validation
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Title and content cannot be empty.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO posts (UserID, Title, Content, IsDraft, PublishedAt) VALUES (@UserID, @Title, @Content, 0, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@UserID", userId); // Pass logged-in user ID
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Update post count
                    string updateQuery = "UPDATE users SET ArticlesCount = ArticlesCount + 1 WHERE UserID = @UserID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@UserID", userId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Post published successfully!");
                    LoadHomeFeed(); // Refresh home feed

                    // Clear inputs
                    txtTitle.Clear();
                    txtContent.Clear();
                    pbPostImage.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadHomeFeed()
        {
            if (flpPosts == null) // Initialize if null
            {
                flpPosts = new FlowLayoutPanel
                {
                    AutoScroll = true,
                    Size = new Size(660, 400),
                    Location = new Point(20, 20),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke
                };
                pnlHome.Controls.Add(flpPosts); // Add to home panel
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT Posts.PostID, Posts.Title, Posts.Content, Posts.ImagePath, 
                       Users.Username, Users.ProfilePicture, 
                       (SELECT COUNT(*) FROM Likes WHERE Likes.PostID = Posts.PostID) AS LikesCount,
                       (SELECT COUNT(*) FROM Comments WHERE Comments.PostID = Posts.PostID) AS CommentsCount
                FROM Posts
                JOIN Users ON Posts.UserID = Users.UserID
                ORDER BY Posts.PublishedAt DESC"; // Fetch latest posts first

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // **Post Container**
                            Panel postCard = new Panel
                            {
                                Size = new Size(850, 300),
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10),
                                BackColor = Color.White
                            };

                            // **User Info Row**
                            PictureBox pbProfile = new PictureBox
                            {
                                Size = new Size(40, 40),
                                Location = new Point(10, 10),
                                Image = File.Exists(reader["ProfilePicture"].ToString())
                                        ? Image.FromFile(reader["ProfilePicture"].ToString())
                                        : Properties.Resources.defaultProfilePic,
                                SizeMode = PictureBoxSizeMode.StretchImage
                            };

                            Label lblUsername = new Label
                            {
                                Text = reader["Username"].ToString(),
                                Location = new Point(60, 15),
                                Font = new Font("Arial", 10, FontStyle.Bold),
                                AutoSize = true
                            };

                            // **Post Image**
                            PictureBox pbPostImage = new PictureBox
                            {
                                Size = new Size(800, 150),
                                Location = new Point(10, 60),
                                Image = File.Exists(reader["ImagePath"].ToString())
                                        ? Image.FromFile(reader["ImagePath"].ToString())
                                        : Properties.Resources.placeholder_image,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            // **Post Caption/Title**
                            Label lblTitle = new Label
                            {
                                Text = reader["Title"].ToString(),
                                Location = new Point(10, 220),
                                Font = new Font("Arial", 12, FontStyle.Bold),
                                AutoSize = true
                            };

                            // **Action Row**
                            PictureBox btnLike = new PictureBox
                            {
                                Size = new Size(24, 24),
                                Location = new Point(10, 250),
                                Image = Properties.Resources.like_icon, // Replace with actual icon
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Cursor = Cursors.Hand,
                                Tag = reader["PostID"] // Store Post ID for later use
                            };

                            PictureBox btnDislike = new PictureBox
                            {
                                Size = new Size(24, 24),
                                Location = new Point(50, 250),
                                Image = Properties.Resources.dislike_icon, // Replace with actual icon
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Cursor = Cursors.Hand,
                                Tag = reader["PostID"]
                            };

                            PictureBox btnComment = new PictureBox
                            {
                                Size = new Size(24, 24),
                                Location = new Point(90, 250),
                                Image = Properties.Resources.comment_icon, // Replace with actual icon
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Cursor = Cursors.Hand,
                                Tag = reader["PostID"]
                            };

                            Label lblLikes = new Label
                            {
                                Text = reader["LikesCount"].ToString() + " Likes",
                                Location = new Point(130, 255),
                                AutoSize = true
                            };

                            Label lblComments = new Label
                            {
                                Text = reader["CommentsCount"].ToString() + " Comments",
                                Location = new Point(200, 255),
                                AutoSize = true
                            };

                            // **Add Controls to Post Card**
                            postCard.Controls.Add(pbProfile);
                            postCard.Controls.Add(lblUsername);
                            postCard.Controls.Add(pbPostImage);
                            postCard.Controls.Add(lblTitle);
                            postCard.Controls.Add(btnLike);
                            postCard.Controls.Add(btnDislike);
                            postCard.Controls.Add(btnComment);
                            postCard.Controls.Add(lblLikes);
                            postCard.Controls.Add(lblComments);

                            // **Add Post Card to Feed**
                            flpPosts.Controls.Add(postCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading home feed: " + ex.Message);
            }
        }










        private void pbCameraIcon_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Update Picture", null, UpdatePicture_Click);
            menu.Items.Add("Delete Current Picture", null, DeletePicture_Click);
            menu.Show(Cursor.Position);
        }

        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Preview the selected image in PictureBox (e.g., pbPostImage)
                pbPostImage.Image = Image.FromFile(selectedImagePath); // Ensure PictureBox is added in Designer
                pbPostImage.SizeMode = PictureBoxSizeMode.StretchImage;

                // Save image path to be used later for database insertion
                selectedImage = selectedImagePath; // Use this variable to save in DB
            }
        }
    }
}
