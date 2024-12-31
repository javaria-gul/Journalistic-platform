using System;
using System.Drawing;
using System.Windows.Forms;

namespace TRENDZZ
{
    public partial class Form1 : Form
    {
        private Timer fadeTimer;
        private int fadeOpacity = 255;

        public Form1()
        {
            InitializeComponent();
            InitializeFadeTimer(); // Initialize the fade timer
            lblTrendzz.Paint += LblTrendzz_Paint; // Attach Paint event to lblTrendzz
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up lblTrendzz for the initial display
            lblTrendzz.Text = "";
            lblTrendzz.BackColor = Color.Black;
        }

        private void InitializeFadeTimer()
        {
            // Timer for handling the fade effect
            fadeTimer = new Timer
            {
                Interval = 150 // Adjust for smooth fade effect
            };
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start(); // Start fading
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            // Gradually reduce opacity
            fadeOpacity -= 15;
            if (fadeOpacity <= 0)
            {
                fadeOpacity = 0;
                fadeTimer.Stop();
                lblTrendzz.Visible = false; // Hide lblTrendzz after fade

                // Transition to RoleSelectionForm
                RoleSelectionForm roleSelection = new RoleSelectionForm();
                roleSelection.Show();
                this.Hide(); // Hide current form
            }
            lblTrendzz.Invalidate(); // Redraw lblTrendzz with updated opacity
        }

        private void LblTrendzz_Paint(object sender, PaintEventArgs e)
        {
            // Custom rendering for lblTrendzz
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            string text = "TRENDZZ";
            Font font = new Font("Bernard MT", 30, FontStyle.Bold);

            // Rainbow colors
            Brush[] brushes = new Brush[]
            {
                Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green,
                Brushes.Blue, Brushes.Indigo, Brushes.Violet
            };

            // Calculate total text width for centering
            float totalWidth = 0;
            for (int i = 0; i < text.Length; i++)
            {
                totalWidth += e.Graphics.MeasureString(text[i].ToString(), font).Width;
            }

            // Calculate starting position for centered text
            float startX = (lblTrendzz.Width - totalWidth) / 2;
            float startY = (lblTrendzz.Height - font.Height) / 2;

            // Draw each character with its corresponding color
            for (int i = 0; i < text.Length; i++)
            {
                Color fadedColor = Color.FromArgb(fadeOpacity, ((SolidBrush)brushes[i]).Color);
                using (Brush fadedBrush = new SolidBrush(fadedColor))
                {
                    e.Graphics.DrawString(text[i].ToString(), font, fadedBrush, startX, startY);
                }
                startX += e.Graphics.MeasureString(text[i].ToString(), font).Width;
            }
        }

        private void lblTrendzz_Click(object sender, EventArgs e)
        {

        }
    }
}
