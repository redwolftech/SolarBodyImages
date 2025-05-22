using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarBodyImages
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private void WaitUI()
        {
            this.Cursor = Cursors.WaitCursor;
            //btnRenderImage.Enabled = false;
        }

        private void RestoreUI()
        {
            this.Cursor = Cursors.Default;
            //btnRenderImage.Enabled = true;
        }

        public void Init()
        {
            // Load existing planet bitmap
            pbPlanetMap.Image = ImageUtilities.LoadImage(Application.StartupPath + @"\Planet\map.bmp");

            // Load existing clouds bitmap
            Bitmap bmpCloudsMap = new Bitmap(Application.StartupPath + @"\Planet\clouds.bmp");
            pbCloudsMap.Image = bmpCloudsMap;

            // Starting random seed
            Random oRand = new Random();
            double dblSeed = Math.Round(oRand.NextDouble(), 8);
            numSeed.Value = (decimal)dblSeed;

            // Color files
            foreach (string file in Directory.EnumerateFiles(Application.StartupPath + @"\Planet", "*.col"))
            {
                cbColor.Items.Add(Path.GetFileNameWithoutExtension(file));
                if (Path.GetFileNameWithoutExtension(file) == "Olsson")
                    cbColor.SelectedIndex = cbColor.Items.Count - 1;
            }
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            // Reset to defaults

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // New random seed
            Random oRand = new Random();
            double dblSeed = Math.Round(oRand.NextDouble(), 8);
            numSeed.Value = (decimal) dblSeed;
        }

        // Generate new planet based on parameters
        private void btnGeneratePlanet_Click(object sender, EventArgs e)
        {
            // Wait UI
            WaitUI();

            // Create arguments to pass to planet.exe
            string args = @" -w 1000 -h 500 -pm";
            //string args = @" -w 4096 -h 2048 -pm";
            if (chkAltitudeColor.Checked)
                args = args + @" -c";
            args = args + @" -o map.bmp";
            args = args + @" -C " + cbColor.SelectedItem.ToString() + ".col";
            args = args + @" -s " + numSeed.Value.ToString();
            if (rdoBumpmap.Checked)
                args = args + @" -B";
            if (rdoBumpmapLandOnly.Checked)
                args = args + @" -b";
            args = args + @" -i " + numAltitude.Value.ToString();

            // Create process, execute and wait for it to complete
            string command = Application.StartupPath + @"\Planet\" + "planet.exe";
            ProcessStartInfo start = new ProcessStartInfo(command, args);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.WorkingDirectory = Application.StartupPath + @"\Planet";
            Process.Start(start).WaitForExit();

            // Reload map files
            FileStream bmpFile = File.OpenRead(Application.StartupPath + @"\Planet\map.bmp");
            Bitmap bmpPlanetMap = new Bitmap(bmpFile);
            bmpFile.Close();
            bmpFile.Dispose();
            pbPlanetMap.Image = bmpPlanetMap;

            // Restore UI
            RestoreUI();
        }

        // Generate new clouds based on parameters
        private void btnGenerateClouds_Click(object sender, EventArgs e)
        {

        }

        private void tbarCloudDensity_ValueChanged(object sender, EventArgs e)
        {
            lblCloudDensityPercent.Text = "(" + tbarCloudDensity.Value.ToString() + "%)";
            lblCloudDensityPercent.Refresh();
        }

        private void btnNewSeedGenerate_Click(object sender, EventArgs e)
        {
            // New random seed
            Random oRand = new Random();
            double dblSeed = Math.Round(oRand.NextDouble(), 8);
            numSeed.Value = (decimal)dblSeed;

            // Click generate
            btnGeneratePlanet_Click(this, e);
        }

    }
}
