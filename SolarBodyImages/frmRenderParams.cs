using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarBodyImages
{
    public partial class frmRenderParams : Form
    {
        // Lighting source
        public RTPlanet.enumLightingSource Source = RTPlanet.enumLightingSource.NorthWest;

        public frmRenderParams()
        {
            InitializeComponent();
        }

        private void SetDefaults()
        {
            chkShadows.Checked = true;
            chkShadowPlanetColor.Checked = false;
            rdNW.Checked = true;
            btnShadowColor.BackColor = Color.Black;
            tbarStrength.Value = 35;
            chkGlow.Checked = true;
            chkGlowOffset.Checked = false;
            chkGlowPlanetColor.Checked = true;
            btnGlowColor1.BackColor = Color.LightBlue;
            btnGlowColor2.BackColor = Color.DarkBlue;
            numGlowPercent.Value = 104;
            cbCloudSpeed.SelectedIndex = 1; // Start on same speed
            cbSmoothness.SelectedIndex = 2; // Start on medium
            numTiltX.Value = 1.5M;
            numTiltY.Value = -2.5M;
        }

        public void Init()
        {
            // Load cloud speeds
            cbCloudSpeed.Items.Add("Slightly Slower");
            cbCloudSpeed.Items.Add("Same Speed");
            cbCloudSpeed.Items.Add("Slightly Faster");

            // Load # of frames
            cbSmoothness.Items.Add("Super (120)");
            cbSmoothness.Items.Add("High (60)");
            cbSmoothness.Items.Add("Medium (30)");
            cbSmoothness.Items.Add("Low (15)");

            SetDefaults();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Create/set color dialog
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.AllowFullOpen = true;
            dlgColor.Color = ((Button)sender).BackColor;

            // Show and check for result
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = dlgColor.Color;
            }
        }

        private void rdSource_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdSource = sender as RadioButton;

            if (rdSource != null)
            {
                if (rdSource.Checked)
                {
                    // Got checked radio button
                    switch (rdSource.Name)
                    {
                        case "rdC":
                            Source = RTPlanet.enumLightingSource.Center;
                            break;
                        case "rdN":
                            Source = RTPlanet.enumLightingSource.North;
                            break;
                        case "rdNE":
                            Source = RTPlanet.enumLightingSource.NorthEast;
                            break;
                        case "rdE":
                            Source = RTPlanet.enumLightingSource.East;
                            break;
                        case "rdSE":
                            Source = RTPlanet.enumLightingSource.SouthEast;
                            break;
                        case "rdS":
                            Source = RTPlanet.enumLightingSource.South;
                            break;
                        case "rdSW":
                            Source = RTPlanet.enumLightingSource.SouthWest;
                            break;
                        case "rdW":
                            Source = RTPlanet.enumLightingSource.West;
                            break;
                        case "rdNW":
                            Source = RTPlanet.enumLightingSource.NorthWest;
                            break;
                    }
                }
            }
        }

        private void tbarStrength_ValueChanged(object sender, EventArgs e)
        {
            lblLightingStrength.Text = "(" + tbarStrength.Value.ToString() + "%)";
            lblLightingStrength.Refresh();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

    }
}
