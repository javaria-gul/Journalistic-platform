using System.Windows.Forms;

namespace TRENDZZ
{
    partial class JournalistDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flpPosts;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalistDashboard));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbHeart = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeNameBio = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.lblsettingstext = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSettingsIcon = new System.Windows.Forms.PictureBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblPosts = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbCameraIcon = new System.Windows.Forms.PictureBox();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnPublishPost = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbPostImage = new System.Windows.Forms.PictureBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.pnlAddPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Yellow;
            this.pnlSidebar.Controls.Add(this.pbBack);
            this.pnlSidebar.Controls.Add(this.pbSearch);
            this.pnlSidebar.Controls.Add(this.pbAdd);
            this.pnlSidebar.Controls.Add(this.pbHeart);
            this.pnlSidebar.Controls.Add(this.pbProfile);
            this.pnlSidebar.Controls.Add(this.pbHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(80, 731);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBack.Image = global::TRENDZZ.Properties.Resources.icons8_back_50;
            this.pbBack.Location = new System.Drawing.Point(0, 669);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(80, 62);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::TRENDZZ.Properties.Resources.icons8_search_50;
            this.pbSearch.Location = new System.Drawing.Point(0, 93);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(87, 57);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Image = global::TRENDZZ.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(0, 169);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(87, 56);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbHeart
            // 
            this.pbHeart.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart.Image = global::TRENDZZ.Properties.Resources.icons8_heart_50;
            this.pbHeart.Location = new System.Drawing.Point(0, 243);
            this.pbHeart.Name = "pbHeart";
            this.pbHeart.Size = new System.Drawing.Size(87, 59);
            this.pbHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart.TabIndex = 2;
            this.pbHeart.TabStop = false;
            this.pbHeart.Click += new System.EventHandler(this.pbHeart_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbProfile.Image = global::TRENDZZ.Properties.Resources.icons8_user_50;
            this.pbProfile.Location = new System.Drawing.Point(0, 320);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(87, 65);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 1;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.Image = global::TRENDZZ.Properties.Resources.icons8_home_50;
            this.pbHome.Location = new System.Drawing.Point(0, 12);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(87, 62);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlProfile);

            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(80, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1368, 731);
            this.pnlHome.TabIndex = 1;
            this.pnlHome.Visible = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.White;
            this.pnlProfile.Controls.Add(this.pnlSettings);
            this.pnlProfile.Controls.Add(this.panel1);
            this.pnlProfile.Controls.Add(this.txtBio);
            this.pnlProfile.Controls.Add(this.lblFollowing);
            this.pnlProfile.Controls.Add(this.lblFollowers);
            this.pnlProfile.Controls.Add(this.lblPosts);
            this.pnlProfile.Controls.Add(this.lblName);
            this.pnlProfile.Controls.Add(this.pbCameraIcon);
            this.pnlProfile.Controls.Add(this.pbProfilePic);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlProfile.Location = new System.Drawing.Point(80, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(1368, 731);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Visible = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.btnChangePassword);
            this.pnlSettings.Controls.Add(this.btnChangeNameBio);
            this.pnlSettings.Controls.Add(this.btnLogout);
            this.pnlSettings.Controls.Add(this.btnChangeUsername);
            this.pnlSettings.Controls.Add(this.lblsettingstext);
            this.pnlSettings.Location = new System.Drawing.Point(59, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1160, 725);
            this.pnlSettings.TabIndex = 9;
            this.pnlSettings.Visible = false;
            this.pnlSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSettings_Paint);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangePassword.Location = new System.Drawing.Point(448, 300);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(262, 48);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password\n";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnChangeNameBio
            // 
            this.btnChangeNameBio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangeNameBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeNameBio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangeNameBio.Location = new System.Drawing.Point(448, 393);
            this.btnChangeNameBio.Name = "btnChangeNameBio";
            this.btnChangeNameBio.Size = new System.Drawing.Size(262, 43);
            this.btnChangeNameBio.TabIndex = 3;
            this.btnChangeNameBio.Text = "Change Name n Bio\r\n";
            this.btnChangeNameBio.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogout.Location = new System.Drawing.Point(448, 484);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 43);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangeUsername.Location = new System.Drawing.Point(448, 209);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(262, 47);
            this.btnChangeUsername.TabIndex = 1;
            this.btnChangeUsername.Text = "Change Username\n";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            // 
            // lblsettingstext
            // 
            this.lblsettingstext.AutoSize = true;
            this.lblsettingstext.BackColor = System.Drawing.Color.Transparent;
            this.lblsettingstext.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsettingstext.ForeColor = System.Drawing.Color.LightYellow;
            this.lblsettingstext.Location = new System.Drawing.Point(468, 81);
            this.lblsettingstext.Name = "lblsettingstext";
            this.lblsettingstext.Size = new System.Drawing.Size(209, 64);
            this.lblsettingstext.TabIndex = 0;
            this.lblsettingstext.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbSettingsIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1264, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 731);
            this.panel1.TabIndex = 8;
            // 
            // pbSettingsIcon
            // 
            this.pbSettingsIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbSettingsIcon.Image = global::TRENDZZ.Properties.Resources.icons8_setting_50;
            this.pbSettingsIcon.Location = new System.Drawing.Point(0, 644);
            this.pbSettingsIcon.Name = "pbSettingsIcon";
            this.pbSettingsIcon.Size = new System.Drawing.Size(104, 87);
            this.pbSettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettingsIcon.TabIndex = 7;
            this.pbSettingsIcon.TabStop = false;
            this.pbSettingsIcon.Click += new System.EventHandler(this.pbSettingsIcon_Click);
            // 
            // txtBio
            // 
            this.txtBio.BackColor = System.Drawing.Color.White;
            this.txtBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBio.ForeColor = System.Drawing.Color.Black;
            this.txtBio.Location = new System.Drawing.Point(111, 453);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.ReadOnly = true;
            this.txtBio.Size = new System.Drawing.Size(320, 167);
            this.txtBio.TabIndex = 6;
            this.txtBio.TabStop = false;
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowing.ForeColor = System.Drawing.Color.Black;
            this.lblFollowing.Location = new System.Drawing.Point(854, 380);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(138, 29);
            this.lblFollowing.TabIndex = 5;
            this.lblFollowing.Text = "0 Following";
            this.lblFollowing.Click += new System.EventHandler(this.lblFollowing_Click);
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.ForeColor = System.Drawing.Color.Black;
            this.lblFollowers.Location = new System.Drawing.Point(678, 380);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(139, 29);
            this.lblFollowers.TabIndex = 4;
            this.lblFollowers.Text = "0 Followers";
            this.lblFollowers.Click += new System.EventHandler(this.lblFollowers_Click);
            // 
            // lblPosts
            // 
            this.lblPosts.AutoSize = true;
            this.lblPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosts.ForeColor = System.Drawing.Color.Black;
            this.lblPosts.Location = new System.Drawing.Point(520, 380);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(92, 29);
            this.lblPosts.TabIndex = 3;
            this.lblPosts.Text = "0 Posts";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(517, 282);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 46);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Username";
            // 
            // pbCameraIcon
            // 
            this.pbCameraIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbCameraIcon.Image = global::TRENDZZ.Properties.Resources.icons8_camera_50;
            this.pbCameraIcon.Location = new System.Drawing.Point(384, 376);
            this.pbCameraIcon.Name = "pbCameraIcon";
            this.pbCameraIcon.Size = new System.Drawing.Size(57, 39);
            this.pbCameraIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCameraIcon.TabIndex = 1;
            this.pbCameraIcon.TabStop = false;
            this.pbCameraIcon.Click += new System.EventHandler(this.pbCameraIcon_Click);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePic.Location = new System.Drawing.Point(111, 113);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(320, 302);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(80, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1368, 731);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.Visible = false;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotifications.Location = new System.Drawing.Point(80, 0);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1368, 731);
            this.pnlNotifications.TabIndex = 0;
            this.pnlNotifications.Visible = false;
            // 
            // pnlAddPost
            // 
            this.pnlAddPost.Controls.Add(this.btnSaveDraft);
            this.pnlAddPost.Controls.Add(this.btnPublishPost);
            this.pnlAddPost.Controls.Add(this.btnUploadImage);
            this.pnlAddPost.Controls.Add(this.pbPostImage);
            this.pnlAddPost.Controls.Add(this.txtContent);
            this.pnlAddPost.Controls.Add(this.lblContent);
            this.pnlAddPost.Controls.Add(this.txtTitle);
            this.pnlAddPost.Controls.Add(this.lblTitle);
            this.pnlAddPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddPost.Location = new System.Drawing.Point(80, 0);
            this.pnlAddPost.Name = "pnlAddPost";
            this.pnlAddPost.Size = new System.Drawing.Size(1368, 731);
            this.pnlAddPost.TabIndex = 0;
            this.pnlAddPost.Visible = false;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.BackColor = System.Drawing.Color.White;
            this.btnSaveDraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraft.Location = new System.Drawing.Point(308, 647);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(139, 46);
            this.btnSaveDraft.TabIndex = 8;
            this.btnSaveDraft.Text = "Save as Draft\n";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            // 
            // btnPublishPost
            // 
            this.btnPublishPost.BackColor = System.Drawing.Color.White;
            this.btnPublishPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishPost.Location = new System.Drawing.Point(519, 647);
            this.btnPublishPost.Name = "btnPublishPost";
            this.btnPublishPost.Size = new System.Drawing.Size(138, 46);
            this.btnPublishPost.TabIndex = 7;
            this.btnPublishPost.Text = "Publish";
            this.btnPublishPost.UseVisualStyleBackColor = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(1028, 505);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(138, 38);
            this.btnUploadImage.TabIndex = 6;
            this.btnUploadImage.Text = "Upload Image\n";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbPostImage
            // 
            this.pbPostImage.BackColor = System.Drawing.Color.White;
            this.pbPostImage.Location = new System.Drawing.Point(854, 152);
            this.pbPostImage.Name = "pbPostImage";
            this.pbPostImage.Size = new System.Drawing.Size(464, 323);
            this.pbPostImage.TabIndex = 5;
            this.pbPostImage.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(193, 152);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(623, 472);
            this.txtContent.TabIndex = 4;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(53, 169);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(126, 36);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Content";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(193, 91);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(464, 39);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(69, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JournalistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1448, 731);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlAddPost);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalistDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalistDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JournalistDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.pnlAddPost.ResumeLayout(false);
            this.pnlAddPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbHeart;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlAddPost;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.PictureBox pbCameraIcon;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblPosts;
        private System.Windows.Forms.PictureBox pbSettingsIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblsettingstext;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeNameBio;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbPostImage;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnPublishPost;
    }
}