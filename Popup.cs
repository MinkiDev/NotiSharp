using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace NotiSharp
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            CurrentTimeLabel.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            StartPosition = FormStartPosition.Manual;
            Location = GetLocation();
            //SystemSounds.Beep.Play();
        }

        public void SetIcon(Bitmap res)
        {
            if (Icon != null) PopupLogo.Image = res;
        }

        public void SetText(string content)
        {
            if (Text != null) ContentArea.Text = content;
        }

        private const int Marx = 10; // X Position Margin
        private const int Mary = 10; // Y Position Margin

        private Point GetLocation()
        {
            Rectangle wArea = Screen.GetWorkingArea(this); // Get First Moniter's Workspace Size (Without Taskbar)
            var width = wArea.Width - Marx - Size.Width;
            var height = wArea.Height - Mary - Size.Height;
            return new Point(width, height); // Send to Point
        }

        private void PopupLogo_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void InnerPane_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ContentArea_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}