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
    public partial class Form1 : Form
    {
        private Timer fadeTimer; // Timer for fading effect
        private int fadeOpacity = 255; // Initial opacity

        public Form1()
        {
            InitializeComponent();
            InitializeFadeTimer();
            lblTrendzz.Paint += LblTrendzz_Paint; // Attach Paint event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear any default label text and set transparent background
            lblTrendzz.Text = "";
            lblTrendzz.BackColor = Color.Transparent;
        }

        private void InitializeFadeTimer()
        {
            fadeTimer = new Timer
            {
                Interval = 200 // 100ms interval
            };
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            fadeOpacity -= 15; // Gradually decrease opacity
            if (fadeOpacity <= 0)
            {
                fadeOpacity = 0;
                fadeTimer.Stop(); // Stop the timer
                lblTrendzz.Visible = false; // Hide the label
            }
            lblTrendzz.Invalidate(); // Force redraw
        }

        private void LblTrendzz_Paint(object sender, PaintEventArgs e)
        {
            string text = "TRENDZZ";
            Font font = new Font("Arial", 36, FontStyle.Bold);

            // Brush array for colors
            Brush[] brushes = new Brush[]
            {
        Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green,
        Brushes.Blue, Brushes.Indigo, Brushes.Violet
            };

            // Measure the total width of the text
            float totalWidth = 0;
            for (int i = 0; i < text.Length; i++)
            {
                totalWidth += e.Graphics.MeasureString(text[i].ToString(), font).Width;
            }

            // Calculate starting positions to center the text
            float startX = (lblTrendzz.Width - totalWidth) / 2; // Center horizontally
            float startY = (lblTrendzz.Height - font.Height) / 2; // Center vertically

            // Draw each character in its respective color
            for (int i = 0; i < text.Length; i++)
            {
                Color fadedColor = Color.FromArgb(fadeOpacity, ((SolidBrush)brushes[i]).Color);
                using (Brush fadedBrush = new SolidBrush(fadedColor))
                {
                    e.Graphics.DrawString(text[i].ToString(), font, fadedBrush, startX, startY);
                }
                startX += e.Graphics.MeasureString(text[i].ToString(), font).Width; // Increment X for the next character
            }
        }
    }
}
