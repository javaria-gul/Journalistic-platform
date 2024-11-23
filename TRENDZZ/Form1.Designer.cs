namespace TRENDZZ
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTrendzz = new System.Windows.Forms.Label();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTrendzz
            // 
            this.lblTrendzz.BackColor = System.Drawing.Color.Black;
            this.lblTrendzz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrendzz.Font = new System.Drawing.Font("Arial Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrendzz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTrendzz.Location = new System.Drawing.Point(0, 0);
            this.lblTrendzz.Name = "lblTrendzz";
            this.lblTrendzz.Size = new System.Drawing.Size(978, 744);
            this.lblTrendzz.TabIndex = 0;
            this.lblTrendzz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerFade
            // 
            this.timerFade.Interval = 6000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.lblTrendzz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrendzz;
        private System.Windows.Forms.Timer timerFade;
    }
}

