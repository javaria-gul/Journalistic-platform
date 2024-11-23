namespace TRENDZZ
{
    partial class RoleSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSelectionForm));
            this.roleselectionlable = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.JournalistButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roleselectionlable
            // 
            this.roleselectionlable.AutoSize = true;
            this.roleselectionlable.BackColor = System.Drawing.Color.Transparent;
            this.roleselectionlable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleselectionlable.ForeColor = System.Drawing.Color.White;
            this.roleselectionlable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roleselectionlable.Location = new System.Drawing.Point(302, 66);
            this.roleselectionlable.Name = "roleselectionlable";
            this.roleselectionlable.Size = new System.Drawing.Size(377, 51);
            this.roleselectionlable.TabIndex = 0;
            this.roleselectionlable.Text = "Select Your Role";
            this.roleselectionlable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Transparent;
            this.AdminButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.AdminButton.Location = new System.Drawing.Point(399, 221);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(172, 69);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "ADMIN";
            this.AdminButton.UseVisualStyleBackColor = false;
            // 
            // JournalistButton
            // 
            this.JournalistButton.BackColor = System.Drawing.Color.Transparent;
            this.JournalistButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalistButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.JournalistButton.Location = new System.Drawing.Point(354, 317);
            this.JournalistButton.Name = "JournalistButton";
            this.JournalistButton.Size = new System.Drawing.Size(255, 70);
            this.JournalistButton.TabIndex = 2;
            this.JournalistButton.Text = "JOURNALIST";
            this.JournalistButton.UseVisualStyleBackColor = false;
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.Transparent;
            this.UserButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.UserButton.Location = new System.Drawing.Point(394, 418);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(177, 67);
            this.UserButton.TabIndex = 3;
            this.UserButton.Text = "USER";
            this.UserButton.UseVisualStyleBackColor = false;
            // 
            // RoleSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TRENDZZ.Properties.Resources.blockchain_7660382;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.JournalistButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.roleselectionlable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoleSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleSelectionForm";
            this.Load += new System.EventHandler(this.RoleSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleselectionlable;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button JournalistButton;
        private System.Windows.Forms.Button UserButton;
    }
}