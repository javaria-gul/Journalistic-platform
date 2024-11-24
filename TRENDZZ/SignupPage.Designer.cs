namespace TRENDZZ
{
    partial class SignupPage
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
            System.Windows.Forms.Label Signuplabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.CompanyNamelabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SignupButton = new System.Windows.Forms.Button();
            Signuplabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signuplabel
            // 
            Signuplabel.AutoSize = true;
            Signuplabel.BackColor = System.Drawing.Color.Transparent;
            Signuplabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Signuplabel.ForeColor = System.Drawing.Color.White;
            Signuplabel.Location = new System.Drawing.Point(365, 92);
            Signuplabel.Name = "Signuplabel";
            Signuplabel.Size = new System.Drawing.Size(225, 55);
            Signuplabel.TabIndex = 0;
            Signuplabel.Text = "SIGN UP";
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelabel.ForeColor = System.Drawing.Color.White;
            this.Usernamelabel.Location = new System.Drawing.Point(192, 201);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(144, 32);
            this.Usernamelabel.TabIndex = 1;
            this.Usernamelabel.Text = "Username";
            this.Usernamelabel.Click += new System.EventHandler(this.Usernamelabel_Click);
            // 
            // CompanyNamelabel
            // 
            this.CompanyNamelabel.AutoSize = true;
            this.CompanyNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.CompanyNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNamelabel.ForeColor = System.Drawing.Color.White;
            this.CompanyNamelabel.Location = new System.Drawing.Point(192, 395);
            this.CompanyNamelabel.Name = "CompanyNamelabel";
            this.CompanyNamelabel.Size = new System.Drawing.Size(217, 32);
            this.CompanyNamelabel.TabIndex = 2;
            this.CompanyNamelabel.Text = "Company Name";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.Emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.ForeColor = System.Drawing.Color.White;
            this.Emaillabel.Location = new System.Drawing.Point(192, 329);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(86, 32);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "Email";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.White;
            this.Passwordlabel.Location = new System.Drawing.Point(192, 264);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(138, 32);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(447, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 37);
            this.txtUsername.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(447, 390);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(278, 37);
            this.txtCompanyName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(447, 324);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 37);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(447, 259);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 37);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SignupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.Black;
            this.SignupButton.Location = new System.Drawing.Point(424, 477);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(97, 46);
            this.SignupButton.TabIndex = 9;
            this.SignupButton.Text = "Sign Up";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TRENDZZ.Properties.Resources.milkyway_8190232;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.CompanyNamelabel);
            this.Controls.Add(this.Usernamelabel);
            this.Controls.Add(Signuplabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupPage";
            this.Load += new System.EventHandler(this.SignupPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label CompanyNamelabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button SignupButton;
    }
}