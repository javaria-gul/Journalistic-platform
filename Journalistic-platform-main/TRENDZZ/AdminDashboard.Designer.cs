namespace TRENDZZ
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.chartMonthlyUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUserList = new System.Windows.Forms.Panel();
            this.panelAdmin.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.White;
            this.panelAdmin.Controls.Add(this.panelHome);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1448, 731);
            this.panelAdmin.TabIndex = 1;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome.Controls.Add(this.panelGraph);
            this.panelHome.Controls.Add(this.panelUserList);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1448, 731);
            this.panelHome.TabIndex = 0;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // panelGraph
            // 
            this.panelGraph.AutoScroll = true;
            this.panelGraph.BackColor = System.Drawing.Color.LightGray;
            this.panelGraph.Controls.Add(this.chartMonthlyUsers);
            this.panelGraph.Controls.Add(this.label1);
            this.panelGraph.Controls.Add(this.chartUsers);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.ForeColor = System.Drawing.Color.AliceBlue;
            this.panelGraph.Location = new System.Drawing.Point(275, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1169, 727);
            this.panelGraph.TabIndex = 1;
            // 
            // chartMonthlyUsers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonthlyUsers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonthlyUsers.Legends.Add(legend1);
            this.chartMonthlyUsers.Location = new System.Drawing.Point(100, 602);
            this.chartMonthlyUsers.Name = "chartMonthlyUsers";
            this.chartMonthlyUsers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Monthly Registrations";
            this.chartMonthlyUsers.Series.Add(series1);
            this.chartMonthlyUsers.Size = new System.Drawing.Size(1081, 516);
            this.chartMonthlyUsers.TabIndex = 2;
            this.chartMonthlyUsers.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(104, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users Data";
            // 
            // chartUsers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUsers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUsers.Legends.Add(legend2);
            this.chartUsers.Location = new System.Drawing.Point(100, 56);
            this.chartUsers.Name = "chartUsers";
            this.chartUsers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Active Users";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total Users";
            this.chartUsers.Series.Add(series2);
            this.chartUsers.Series.Add(series3);
            this.chartUsers.Size = new System.Drawing.Size(1081, 516);
            this.chartUsers.TabIndex = 0;
            this.chartUsers.Text = "chart1";
            // 
            // panelUserList
            // 
            this.panelUserList.BackColor = System.Drawing.Color.LightGray;
            this.panelUserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserList.Location = new System.Drawing.Point(0, 0);
            this.panelUserList.Name = "panelUserList";
            this.panelUserList.Size = new System.Drawing.Size(275, 727);
            this.panelUserList.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1448, 731);
            this.Controls.Add(this.panelAdmin);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelUserList;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyUsers;
    }
}