
using System;
using System.IO;
using System.Windows.Forms;

namespace VoidUnlocker
{
    public partial class guiversion : Form
    {
        public guiversion()
        {
            InitializeComponent();
        }

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
    }
}