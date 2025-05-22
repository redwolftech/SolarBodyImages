using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolarBodyImages
{
    public partial class frmMain : Form
    {
        // Holds raytraced planet class
        private RTPlanet Planet = new RTPlanet();

        // Bitmaps for drawing and planet/clouds textures
        private Bitmap bmpPlanet;
        private Bitmap bmpClouds;

        // Collection for bitmap frames
        private List<Bitmap> bmpAnimation = new List<Bitmap>();

        // Flags
        private bool bRender = true;
        private bool bPlay = true;

        // Parameter forms
        private frmGenerator dlgGenParms = new frmGenerator();
        private frmRenderParams dlgRenderParms = new frmRenderParams();

        public frmMain()
        {
            InitializeComponent();

            // Images for pictureboxes
            pbFrames.Image = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
            pbAnimation.Image = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load planet types
            cbPlanetType.Items.Add("Earth");
            cbPlanetType.Items.Add("Jupiter");
            cbPlanetType.Items.Add("Mars");
            cbPlanetType.Items.Add("Mercury");
            cbPlanetType.Items.Add("Moon");
            cbPlanetType.Items.Add("Neptune");
            cbPlanetType.Items.Add("Phobos");
            cbPlanetType.Items.Add("Pluto");
            cbPlanetType.Items.Add("Saturn");
            cbPlanetType.Items.Add("Uranus");
            cbPlanetType.Items.Add("Venus");
            cbPlanetType.Items.Add("Sun");
            cbPlanetType.Items.Add("Custom");
            cbPlanetType.Items.Add("Generated");
            cbPlanetType.Items.Add("Blank");

            cbPlanetType.SelectedIndex = 0; // Start with Earth selected
            tbPlanetName.Select(); // Focus starts on planet name

            // Initialize forms
            dlgGenParms.Init();
            dlgRenderParms.Init();
        }

        private void cbPlanetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load file based on planet type name
            string sFilename;
            if (cbPlanetType.SelectedIndex < 12)
                sFilename = @"\Textures\" + cbPlanetType.SelectedItem.ToString() + ".jpg";
            else
                sFilename = @"\Textures\Blank.jpg";

            if (cbPlanetType.SelectedIndex == 12)
            {
                tbPlanetTextureFile.Enabled = true;
                tbCloudsTextureFile.Enabled = true;
                btnPlanetTextureFile.Enabled = true;
                btnCloudsTextureFile.Enabled = true;
            }
            else
            {
                tbPlanetTextureFile.Enabled = false;
                tbCloudsTextureFile.Enabled = false;
                btnPlanetTextureFile.Enabled = false;
                btnCloudsTextureFile.Enabled = false;
            }

            // If first item (Earth) also load clouds
            if (cbPlanetType.SelectedIndex == 0)
                bmpClouds = new Bitmap(Application.StartupPath + @"\Textures\Clouds.jpg");
            else
                bmpClouds = null;

            if (cbPlanetType.SelectedIndex == 13)
            {
                sFilename = @"\Planet\map.bmp";
                bmpClouds = new Bitmap(Application.StartupPath + @"\Planet\clouds.bmp");
            }

            //bmpPlanet = new Bitmap(Application.StartupPath + sFilename);
            bmpPlanet = ImageUtilities.LoadImage(Application.StartupPath + sFilename);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bPlay = false;
            Application.DoEvents();
            bmpAnimation.Clear();
            bmpAnimation = null;

            Application.Exit();
        }

        private void WaitUI()
        {
            this.Cursor = Cursors.WaitCursor;
            btnRenderImage.Enabled = false;
            btnRenderFrames.Enabled = false;
            btnExit.Enabled = false;
            btnAbortRender.Enabled = true;
        }

        private void RestoreUI()
        {
            this.Cursor = Cursors.Default;
            btnRenderImage.Enabled = true;
            btnRenderFrames.Enabled = true;
            btnExit.Enabled = true;
            btnAbortRender.Enabled = false;
        }

        private void UpdateRenderStatus(string sMessage)
        {
            tbRenderStatus.Text = sMessage;
            tbRenderStatus.Refresh();
            pbarRender.Refresh();
            Application.DoEvents();
        }

        private void UpdateParams()
        {
            // Load planet parameters
            Planet.Radius = Convert.ToInt16(tbImageRadius.Text);
            Planet.BaseColor = btnBaseColor.BackColor;
            Planet.Longitude = 0;
            if (cbPlanetType.SelectedIndex == 12) // Custom
            {
                Planet.PlanetTexture = new Bitmap(tbPlanetTextureFile.Text);
                if (tbCloudsTextureFile.Text != "")
                    Planet.CloudsTexture = new Bitmap(tbCloudsTextureFile.Text);
                else
                    Planet.CloudsTexture = null;
            }
            else
            {
                Planet.PlanetTexture = bmpPlanet;
                Planet.CloudsTexture = bmpClouds;
            }
            if (cbPlanetType.SelectedIndex == 14)
                Planet.OverrideColor = true;
            else
                Planet.OverrideColor = false;

            // Render parameters
            Planet.Shadows = dlgRenderParms.chkShadows.Checked;
            Planet.ShadowColor = dlgRenderParms.btnShadowColor.BackColor;
            Planet.GlowLowColor = dlgRenderParms.btnGlowColor1.BackColor;
            Planet.GlowHighColor = dlgRenderParms.btnGlowColor2.BackColor;
            Planet.GlowPercent = (100 - (double)(dlgRenderParms.numGlowPercent.Value - 100)) / 100;
            Planet.GlowOffset = dlgRenderParms.chkGlowOffset.Checked;
            Planet.GlowPlanetColor = dlgRenderParms.chkGlowPlanetColor.Checked;
            Planet.TiltX = Convert.ToDouble(dlgRenderParms.numTiltX.Value);
            Planet.TiltY = Convert.ToDouble(dlgRenderParms.numTiltY.Value);
            Planet.LightingSource = dlgRenderParms.Source;
            Planet.ShadowStrength = (dlgRenderParms.tbarStrength.Value * 6) - 100;
            if (dlgRenderParms.chkGlow.Checked)
                Planet.CreateGlowImage();
            else
                Planet.ClearGlowImage();
            Planet.CloudSpeed = (RTPlanet.enumCloudSpeed)dlgRenderParms.cbCloudSpeed.SelectedIndex;
        }

        private void DrawAnimationFrame(int iFrameNum)
        {
            using (Graphics graphics = Graphics.FromImage(pbAnimation.Image))
            {
                // Draw background color to clear frame
                graphics.FillRectangle(new SolidBrush(btnBackColor.BackColor), new Rectangle(0, 0, pbFrames.Image.Width, pbFrames.Image.Height));

                // Resize to fit the preview picturebox if the frame is larger
                Bitmap bmpDraw;
                if ((Convert.ToInt16(tbImageRadius.Text) * 2) > pbFrames.Image.Width)
                    bmpDraw = ImageUtilities.ResizeImage(bmpAnimation[iFrameNum], 140, 140);
                else
                    bmpDraw = bmpAnimation[iFrameNum];

                // Draw on static picturebox centered
                int iX = (pbFrames.Width - bmpDraw.Width) / 2;
                int iY = (pbFrames.Height - bmpDraw.Height) / 2;
                graphics.DrawImage(bmpDraw, iX, iY);
                pbAnimation.Refresh();
            }
        }

        private void DrawPreviewFrame(int iFrameNum)
        {
            using (Graphics graphics = Graphics.FromImage(pbFrames.Image))
            {
                // Draw background color to clear frame
                graphics.FillRectangle(new SolidBrush(btnBackColor.BackColor), new Rectangle(0, 0, pbFrames.Image.Width, pbFrames.Image.Height));

                // Resize to fit the preview picturebox if the frame is larger
                Bitmap bmpDraw;
                if ((Convert.ToInt16(tbImageRadius.Text) * 2) > pbFrames.Image.Width)
                    bmpDraw = ImageUtilities.ResizeImage(bmpAnimation[iFrameNum], 140, 140);
                else
                    bmpDraw = bmpAnimation[iFrameNum];

                // Draw on static picturebox centered
                int iX = (pbFrames.Width - bmpDraw.Width) / 2;
                int iY = (pbFrames.Height - bmpDraw.Height) / 2;
                graphics.DrawImage(bmpDraw, iX, iY);
                pbFrames.Refresh();
            }
        }

        private void RenderFrames(int iTotalFrames, double dblStep)
        {
            // Clear current list of bitmaps
            bmpAnimation.Clear();

            // UI
            WaitUI();

            // Set planet params
            UpdateParams();

            UpdateRenderStatus("Starting rendering process...");


            bRender = true;
            int iStep = 1;
            while (bRender)
            {
                // Add new bitmap to the list
                bmpAnimation.Add(Planet.CreateImage());

                // Draw the body frame
                if (iTotalFrames > 1)
                {
                    if (chkPreview.Checked)
                        DrawPreviewFrame(iStep - 1);
                }
                else
                    DrawPreviewFrame(0);

                // Update status
                double dblPercent = (double)iStep / iTotalFrames;
                int iProgress = (int)Math.Round(dblPercent * 100, 0);
                pbarRender.Value = iProgress;
                pbarRender.Value = iProgress - 1; // For stupid aero-animation bug
                pbarRender.Value = iProgress;
                UpdateRenderStatus("Rendering Frame #" + iStep.ToString() + " of " + iTotalFrames.ToString());

                // Update longitude based on number of frames
                Planet.Longitude = Planet.Longitude + dblStep;

                // Update steps
                iStep++;
                if (iStep > iTotalFrames)
                {
                    bRender = false;
                    btnPlay.Enabled = true;
                }
            }

            // UI
            UpdateRenderStatus("");
            RestoreUI();
        }

        private void btnRenderImage_Click(object sender, EventArgs e)
        {
            // Draw a single frame
            RenderFrames(1, 0);
        }

        private void btnRenderFrames_Click(object sender, EventArgs e)
        {
            // Determine number of frames (smoothness)
            int iNumSteps = 0;
            double dblStep = 0;
            switch (dlgRenderParms.cbSmoothness.SelectedIndex)
            {
                case 0:
                    iNumSteps = 120;
                    dblStep = 0.0525;
                    break;
                case 1:
                    iNumSteps = 60;
                    dblStep = 0.105;
                    break;
                case 2:
                    iNumSteps = 30;
                    dblStep = 0.21;
                    break;
                case 3:
                    iNumSteps = 15;
                    dblStep = 0.42;
                    break;
            }

            // Render/draw all frames
            RenderFrames(iNumSteps, dblStep);

            // Check on buttons
            if (bmpAnimation.Count == iNumSteps)
            {
                btnSaveFrames.Enabled = true;
                btnSaveAnim.Enabled = true;
            }
            else
            {
                btnSaveFrames.Enabled = false;
                btnSaveAnim.Enabled = false;
            }
        }

        private void btnAbortRender_Click(object sender, EventArgs e)
        {
            // Change render flag
            bRender = false;
            pbarRender.Value = 0;
            pbarRender.Refresh();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            bPlay = true;
            int iFrame = 0;
            btnStop.Enabled = true;
            btnPlay.Enabled = false;
            while (bPlay)
            {
                // Draw on static picturebox
                DrawAnimationFrame(iFrame);

                if (rdClockwise.Checked)
                {
                    iFrame++;
                    if (iFrame == bmpAnimation.Count)
                        iFrame = 0;
                }
                else
                {
                    iFrame--;
                    if (iFrame < 0)
                        iFrame = bmpAnimation.Count - 1;
                }

                Application.DoEvents();
                System.Threading.Thread.Sleep(tbarSpeed.Value * 20);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bPlay = false;
            btnPlay.Enabled = true;
        }

        private void tbarSpeed_ValueChanged(object sender, EventArgs e)
        {
            lblSpeed.Text = "(" + (tbarSpeed.Value * 20).ToString() + "ms) Speed:";
            lblSpeed.Refresh();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            // Create/set color dialog
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.AllowFullOpen = true;
            dlgColor.Color = btnBackColor.BackColor;

            // Show and check for result
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                btnBackColor.BackColor = dlgColor.Color;
                pbAnimation.BackColor = dlgColor.Color;
                pbFrames.BackColor = dlgColor.Color;
            }
        }

        private void btnBaseColor_Click(object sender, EventArgs e)
        {
            // Create/set color dialog
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.AllowFullOpen = true;
            dlgColor.Color = btnBaseColor.BackColor;

            // Show and check for result
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                btnBaseColor.BackColor = dlgColor.Color;
            }
        }

        private void btnSaveFrames_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgSave = new FolderBrowserDialog();
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < bmpAnimation.Count; i++)
                {
                    var sFilename = dlgSave.SelectedPath + @"\frame" + i.ToString() + ".png";
                    bmpAnimation[i].Save(sFilename);
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                bmpAnimation[0].Save(dlgSave.FileName);
            }
        }

        private void btnGeneratorParams_Click(object sender, EventArgs e)
        {
            if (dlgGenParms.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnRenderParameters_Click(object sender, EventArgs e)
        {
            if (dlgRenderParms.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSaveAnim_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "ANM files (*.anm)|*.anm|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(dlgSave.FileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, bmpAnimation);
                }
            }
        }

        private void btnLoadAnim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "ANM files (*.anm)|*.anm|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(dlgOpen.FileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bmpAnimation.Clear();
                    bmpAnimation = (List<Bitmap>) bin.Deserialize(stream);
                }
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
            }
        }

        private void btnPlanetTextureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image files (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                tbPlanetTextureFile.Text = dlgOpen.FileName;
            }
        }

        private void btnCloudsTextureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image files (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                tbCloudsTextureFile.Text = dlgOpen.FileName;
            }
        }

    }
}
