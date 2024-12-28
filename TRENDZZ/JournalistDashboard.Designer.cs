namespace TRENDZZ
{
    partial class JournalistDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlAddPost.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSidebar.Controls.Add(this.pbBack);
            this.pnlSidebar.Controls.Add(this.pbSearch);
            this.pnlSidebar.Controls.Add(this.pbAdd);
            this.pnlSidebar.Controls.Add(this.pbHeart);
            this.pnlSidebar.Controls.Add(this.pbProfile);
            this.pnlSidebar.Controls.Add(this.pbHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(76, 731);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBack.Image = global::TRENDZZ.Properties.Resources.icons8_back_50;
            this.pbBack.Location = new System.Drawing.Point(0, 681);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(76, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::TRENDZZ.Properties.Resources.icons8_search_50;
            this.pbSearch.Location = new System.Drawing.Point(12, 100);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(48, 50);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::TRENDZZ.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(12, 180);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(48, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbHeart
            // 
            this.pbHeart.Image = global::TRENDZZ.Properties.Resources.icons8_heart_50;
            this.pbHeart.Location = new System.Drawing.Point(12, 257);
            this.pbHeart.Name = "pbHeart";
            this.pbHeart.Size = new System.Drawing.Size(48, 50);
            this.pbHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart.TabIndex = 2;
            this.pbHeart.TabStop = false;
            this.pbHeart.Click += new System.EventHandler(this.pbHeart_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::TRENDZZ.Properties.Resources.icons8_user_50;
            this.pbProfile.Location = new System.Drawing.Point(12, 345);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(48, 50);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 1;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = global::TRENDZZ.Properties.Resources.icons8_home_50;
            this.pbHome.Location = new System.Drawing.Point(12, 22);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(48, 50);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlSearch);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(76, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1372, 731);
            this.pnlHome.TabIndex = 1;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pnlAddPost);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1372, 731);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.Visible = false;
            // 
            // pnlAddPost
            // 
            this.pnlAddPost.Controls.Add(this.pnlNotifications);
            this.pnlAddPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddPost.Location = new System.Drawing.Point(0, 0);
            this.pnlAddPost.Name = "pnlAddPost";
            this.pnlAddPost.Size = new System.Drawing.Size(1372, 731);
            this.pnlAddPost.TabIndex = 0;
            this.pnlAddPost.Visible = false;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Controls.Add(this.pnlProfile);
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotifications.Location = new System.Drawing.Point(0, 0);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1372, 731);
            this.pnlNotifications.TabIndex = 0;
            this.pnlNotifications.Visible = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(1372, 731);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Visible = false;
            // 
            // JournalistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1448, 731);
            this.Controls.Add(this.pnlHome);
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
            this.pnlHome.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlAddPost.ResumeLayout(false);
            this.pnlNotifications.ResumeLayout(false);
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
    }
}