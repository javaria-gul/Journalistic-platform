namespace TRENDZZ
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.loginlable = new System.Windows.Forms.Label();
            this.Registerlable = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Usernamelable = new System.Windows.Forms.Label();
            this.passwordlable = new System.Windows.Forms.Label();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.roleLable = new System.Windows.Forms.Label();
            this.rolelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(414, 281);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(348, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // loginlable
            // 
            this.loginlable.AutoSize = true;
            this.loginlable.BackColor = System.Drawing.Color.Transparent;
            this.loginlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlable.ForeColor = System.Drawing.Color.White;
            this.loginlable.Location = new System.Drawing.Point(255, 128);
            this.loginlable.Name = "loginlable";
            this.loginlable.Size = new System.Drawing.Size(480, 37);
            this.loginlable.TabIndex = 2;
            this.loginlable.Text = "ENTER YOUR CREDENTIALS";
            // 
            // Registerlable
            // 
            this.Registerlable.AutoSize = true;
            this.Registerlable.BackColor = System.Drawing.Color.Transparent;
            this.Registerlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerlable.ForeColor = System.Drawing.Color.White;
            this.Registerlable.Location = new System.Drawing.Point(257, 595);
            this.Registerlable.Name = "Registerlable";
            this.Registerlable.Size = new System.Drawing.Size(456, 26);
            this.Registerlable.TabIndex = 3;
            this.Registerlable.Text = "If you don\'t have any account, please Register";
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.Black;
            this.Loginbutton.Location = new System.Drawing.Point(429, 464);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(94, 41);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(414, 376);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(348, 35);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseWaitCursor = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Usernamelable
            // 
            this.Usernamelable.AutoSize = true;
            this.Usernamelable.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelable.ForeColor = System.Drawing.Color.White;
            this.Usernamelable.Location = new System.Drawing.Point(209, 281);
            this.Usernamelable.Name = "Usernamelable";
            this.Usernamelable.Size = new System.Drawing.Size(152, 32);
            this.Usernamelable.TabIndex = 8;
            this.Usernamelable.Text = "Username";
            this.Usernamelable.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordlable
            // 
            this.passwordlable.AutoSize = true;
            this.passwordlable.BackColor = System.Drawing.Color.Transparent;
            this.passwordlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlable.ForeColor = System.Drawing.Color.White;
            this.passwordlable.Location = new System.Drawing.Point(209, 376);
            this.passwordlable.Name = "passwordlable";
            this.passwordlable.Size = new System.Drawing.Size(146, 32);
            this.passwordlable.TabIndex = 9;
            this.passwordlable.Text = "Password";
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.ForeColor = System.Drawing.Color.Black;
            this.Registerbutton.Location = new System.Drawing.Point(402, 639);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(135, 41);
            this.Registerbutton.TabIndex = 10;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // roleLable
            // 
            this.roleLable.AutoSize = true;
            this.roleLable.BackColor = System.Drawing.Color.Transparent;
            this.roleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLable.ForeColor = System.Drawing.Color.White;
            this.roleLable.Location = new System.Drawing.Point(408, 155);
            this.roleLable.Name = "roleLable";
            this.roleLable.Size = new System.Drawing.Size(0, 32);
            this.roleLable.TabIndex = 11;
            // 
            // rolelabel
            // 
            this.rolelabel.AutoSize = true;
            this.rolelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rolelabel.Location = new System.Drawing.Point(505, 165);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(0, 20);
            this.rolelabel.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TRENDZZ.Properties.Resources.milkyway_8190232;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.rolelabel);
            this.Controls.Add(this.roleLable);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.passwordlable);
            this.Controls.Add(this.Usernamelable);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Registerlable);
            this.Controls.Add(this.loginlable);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label loginlable;
        private System.Windows.Forms.Label Registerlable;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Usernamelable;
        private System.Windows.Forms.Label passwordlable;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label roleLable;
        private System.Windows.Forms.Label rolelabel;
    }
}