using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRENDZZ
{
    public partial class JournalistDashboard : Form
    {
        private Stack<Panel> panelHistory = new Stack<Panel>();
        public JournalistDashboard()
        {
            InitializeComponent();
            ShowPanel(pnlHome);
        }
        private void ShowPanel(Panel panel)
        {
            // Hide all panels
            pnlHome.Visible = false;
            pnlNotifications.Visible = false;
            pnlSearch.Visible = false;
            pnlAddPost.Visible = false;
            pnlProfile.Visible = false;

            // Show the selected panel
            panel.Visible = true;

            // Push to history for back navigation
            if (panelHistory.Count == 0 || panelHistory.Peek() != panel)
                panelHistory.Push(panel);
        }

        private void JournalistDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlHome);


        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSearch);
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAddPost);
        }

        private void pbHeart_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlNotifications);
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlProfile);
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
    }
}
