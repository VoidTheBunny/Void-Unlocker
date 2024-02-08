using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace VoidUnlocker
{
    public partial class guiversion : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public guiversion()
        {
            InitializeComponent();
        }
        Point lastpoint;
        private void guiversion_Load(object sender, EventArgs e)
        {
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Unlockfps_Click(object sender, EventArgs e)
        {
            try
            {
                string clientSettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Roblox", "ClientSettings");
                if (!Directory.Exists(clientSettingsPath))
                {
                    Directory.CreateDirectory(clientSettingsPath);
                }

                string clientAppSettingsPath = Path.Combine(clientSettingsPath, "ClientAppSettings.json");
                string jsonContent = "{\"DFIntTaskSchedulerTargetFps\": 9999}";
                File.WriteAllText(clientAppSettingsPath, jsonContent);

                MessageBox.Show("FPS Set to 9999", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guiversion_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guiversion_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void guiversion_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }
        }
    }
}
