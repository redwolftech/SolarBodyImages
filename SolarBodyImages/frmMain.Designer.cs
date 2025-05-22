namespace SolarBodyImages
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaseColor = new System.Windows.Forms.Button();
            this.lblBaseColor = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lblSpaceColor = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.rdClockwise = new System.Windows.Forms.RadioButton();
            this.rdCounter = new System.Windows.Forms.RadioButton();
            this.pbarRender = new System.Windows.Forms.ProgressBar();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.tbarSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAnim = new System.Windows.Forms.Label();
            this.pbAnimation = new System.Windows.Forms.PictureBox();
            this.tbRenderStatus = new System.Windows.Forms.TextBox();
            this.lblRenderStatus = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.pbFrames = new System.Windows.Forms.PictureBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.btnRenderParameters = new System.Windows.Forms.Button();
            this.btnGeneratorParams = new System.Windows.Forms.Button();
            this.lblImagePixels = new System.Windows.Forms.Label();
            this.tbImageRadius = new System.Windows.Forms.TextBox();
            this.btnCloudsTextureFile = new System.Windows.Forms.Button();
            this.btnPlanetTextureFile = new System.Windows.Forms.Button();
            this.lblCloudsTexture = new System.Windows.Forms.Label();
            this.lblPlanetTexture = new System.Windows.Forms.Label();
            this.tbCloudsTextureFile = new System.Windows.Forms.TextBox();
            this.tbPlanetTextureFile = new System.Windows.Forms.TextBox();
            this.lblPlanetType = new System.Windows.Forms.Label();
            this.cbPlanetType = new System.Windows.Forms.ComboBox();
            this.tbPlanetName = new System.Windows.Forms.TextBox();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.btnRenderImage = new System.Windows.Forms.Button();
            this.btnRenderFrames = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbortRender = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadFrames = new System.Windows.Forms.Button();
            this.btnSaveFrames = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSaveAnim = new System.Windows.Forms.Button();
            this.btnLoadAnim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrames)).BeginInit();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaseColor);
            this.groupBox1.Controls.Add(this.lblBaseColor);
            this.groupBox1.Controls.Add(this.btnBackColor);
            this.groupBox1.Controls.Add(this.lblSpaceColor);
            this.groupBox1.Controls.Add(this.lblRotation);
            this.groupBox1.Controls.Add(this.rdClockwise);
            this.groupBox1.Controls.Add(this.rdCounter);
            this.groupBox1.Controls.Add(this.pbarRender);
            this.groupBox1.Controls.Add(this.chkPreview);
            this.groupBox1.Controls.Add(this.tbarSpeed);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.lblAnim);
            this.groupBox1.Controls.Add(this.pbAnimation);
            this.groupBox1.Controls.Add(this.tbRenderStatus);
            this.groupBox1.Controls.Add(this.lblRenderStatus);
            this.groupBox1.Controls.Add(this.lblFrames);
            this.groupBox1.Controls.Add(this.pbFrames);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendering:";
            // 
            // btnBaseColor
            // 
            this.btnBaseColor.BackColor = System.Drawing.Color.White;
            this.btnBaseColor.Location = new System.Drawing.Point(206, 160);
            this.btnBaseColor.Name = "btnBaseColor";
            this.btnBaseColor.Size = new System.Drawing.Size(31, 30);
            this.btnBaseColor.TabIndex = 33;
            this.btnBaseColor.UseVisualStyleBackColor = false;
            this.btnBaseColor.Click += new System.EventHandler(this.btnBaseColor_Click);
            // 
            // lblBaseColor
            // 
            this.lblBaseColor.Location = new System.Drawing.Point(203, 130);
            this.lblBaseColor.Name = "lblBaseColor";
            this.lblBaseColor.Size = new System.Drawing.Size(37, 32);
            this.lblBaseColor.TabIndex = 32;
            this.lblBaseColor.Text = "Base Color:";
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.Black;
            this.btnBackColor.Location = new System.Drawing.Point(206, 80);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(31, 30);
            this.btnBackColor.TabIndex = 28;
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // lblSpaceColor
            // 
            this.lblSpaceColor.Location = new System.Drawing.Point(203, 49);
            this.lblSpaceColor.Name = "lblSpaceColor";
            this.lblSpaceColor.Size = new System.Drawing.Size(41, 28);
            this.lblSpaceColor.TabIndex = 27;
            this.lblSpaceColor.Text = "Back Color:";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(263, 217);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(50, 13);
            this.lblRotation.TabIndex = 26;
            this.lblRotation.Text = "Rotation:";
            // 
            // rdClockwise
            // 
            this.rdClockwise.AutoSize = true;
            this.rdClockwise.Checked = true;
            this.rdClockwise.Location = new System.Drawing.Point(319, 215);
            this.rdClockwise.Name = "rdClockwise";
            this.rdClockwise.Size = new System.Drawing.Size(73, 17);
            this.rdClockwise.TabIndex = 25;
            this.rdClockwise.TabStop = true;
            this.rdClockwise.Text = "Clockwise";
            this.rdClockwise.UseVisualStyleBackColor = true;
            // 
            // rdCounter
            // 
            this.rdCounter.AutoSize = true;
            this.rdCounter.Location = new System.Drawing.Point(319, 234);
            this.rdCounter.Name = "rdCounter";
            this.rdCounter.Size = new System.Drawing.Size(62, 17);
            this.rdCounter.TabIndex = 24;
            this.rdCounter.Text = "Counter";
            this.rdCounter.UseVisualStyleBackColor = true;
            // 
            // pbarRender
            // 
            this.pbarRender.Location = new System.Drawing.Point(23, 239);
            this.pbarRender.Name = "pbarRender";
            this.pbarRender.Size = new System.Drawing.Size(160, 15);
            this.pbarRender.Step = 1;
            this.pbarRender.TabIndex = 15;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Location = new System.Drawing.Point(119, 29);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(64, 17);
            this.chkPreview.TabIndex = 12;
            this.chkPreview.Text = "Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // tbarSpeed
            // 
            this.tbarSpeed.AutoSize = false;
            this.tbarSpeed.LargeChange = 1;
            this.tbarSpeed.Location = new System.Drawing.Point(430, 49);
            this.tbarSpeed.Maximum = 50;
            this.tbarSpeed.Minimum = 1;
            this.tbarSpeed.Name = "tbarSpeed";
            this.tbarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSpeed.Size = new System.Drawing.Size(26, 160);
            this.tbarSpeed.TabIndex = 11;
            this.tbarSpeed.TickFrequency = 5;
            this.tbarSpeed.Value = 5;
            this.tbarSpeed.ValueChanged += new System.EventHandler(this.tbarSpeed_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Location = new System.Drawing.Point(359, 29);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(90, 13);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "(100ms) Speed:";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(345, 257);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(264, 257);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblAnim
            // 
            this.lblAnim.AutoSize = true;
            this.lblAnim.Location = new System.Drawing.Point(266, 30);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(56, 13);
            this.lblAnim.TabIndex = 7;
            this.lblAnim.Text = "Animation:";
            // 
            // pbAnimation
            // 
            this.pbAnimation.BackColor = System.Drawing.Color.Black;
            this.pbAnimation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnimation.Location = new System.Drawing.Point(264, 49);
            this.pbAnimation.Name = "pbAnimation";
            this.pbAnimation.Size = new System.Drawing.Size(160, 160);
            this.pbAnimation.TabIndex = 6;
            this.pbAnimation.TabStop = false;
            // 
            // tbRenderStatus
            // 
            this.tbRenderStatus.Location = new System.Drawing.Point(23, 260);
            this.tbRenderStatus.Name = "tbRenderStatus";
            this.tbRenderStatus.ReadOnly = true;
            this.tbRenderStatus.Size = new System.Drawing.Size(160, 20);
            this.tbRenderStatus.TabIndex = 5;
            this.tbRenderStatus.TabStop = false;
            // 
            // lblRenderStatus
            // 
            this.lblRenderStatus.AutoSize = true;
            this.lblRenderStatus.Location = new System.Drawing.Point(22, 219);
            this.lblRenderStatus.Name = "lblRenderStatus";
            this.lblRenderStatus.Size = new System.Drawing.Size(78, 13);
            this.lblRenderStatus.TabIndex = 4;
            this.lblRenderStatus.Text = "Render Status:";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(22, 30);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(44, 13);
            this.lblFrames.TabIndex = 3;
            this.lblFrames.Text = "Frames:";
            // 
            // pbFrames
            // 
            this.pbFrames.BackColor = System.Drawing.Color.Black;
            this.pbFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrames.Location = new System.Drawing.Point(23, 49);
            this.pbFrames.Name = "pbFrames";
            this.pbFrames.Size = new System.Drawing.Size(160, 160);
            this.pbFrames.TabIndex = 2;
            this.pbFrames.TabStop = false;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.btnRenderParameters);
            this.gbParams.Controls.Add(this.btnGeneratorParams);
            this.gbParams.Controls.Add(this.lblImagePixels);
            this.gbParams.Controls.Add(this.tbImageRadius);
            this.gbParams.Controls.Add(this.btnCloudsTextureFile);
            this.gbParams.Controls.Add(this.btnPlanetTextureFile);
            this.gbParams.Controls.Add(this.lblCloudsTexture);
            this.gbParams.Controls.Add(this.lblPlanetTexture);
            this.gbParams.Controls.Add(this.tbCloudsTextureFile);
            this.gbParams.Controls.Add(this.tbPlanetTextureFile);
            this.gbParams.Controls.Add(this.lblPlanetType);
            this.gbParams.Controls.Add(this.cbPlanetType);
            this.gbParams.Controls.Add(this.tbPlanetName);
            this.gbParams.Controls.Add(this.lblPlanetName);
            this.gbParams.Location = new System.Drawing.Point(12, 310);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(473, 163);
            this.gbParams.TabIndex = 1;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Parameters:";
            // 
            // btnRenderParameters
            // 
            this.btnRenderParameters.Location = new System.Drawing.Point(96, 95);
            this.btnRenderParameters.Name = "btnRenderParameters";
            this.btnRenderParameters.Size = new System.Drawing.Size(141, 23);
            this.btnRenderParameters.TabIndex = 33;
            this.btnRenderParameters.Text = "Rendering Parameters";
            this.btnRenderParameters.UseVisualStyleBackColor = true;
            this.btnRenderParameters.Click += new System.EventHandler(this.btnRenderParameters_Click);
            // 
            // btnGeneratorParams
            // 
            this.btnGeneratorParams.Location = new System.Drawing.Point(96, 124);
            this.btnGeneratorParams.Name = "btnGeneratorParams";
            this.btnGeneratorParams.Size = new System.Drawing.Size(141, 23);
            this.btnGeneratorParams.TabIndex = 32;
            this.btnGeneratorParams.Text = "Generator Parameters";
            this.btnGeneratorParams.UseVisualStyleBackColor = true;
            this.btnGeneratorParams.Click += new System.EventHandler(this.btnGeneratorParams_Click);
            // 
            // lblImagePixels
            // 
            this.lblImagePixels.AutoSize = true;
            this.lblImagePixels.Location = new System.Drawing.Point(293, 95);
            this.lblImagePixels.Name = "lblImagePixels";
            this.lblImagePixels.Size = new System.Drawing.Size(75, 13);
            this.lblImagePixels.TabIndex = 17;
            this.lblImagePixels.Text = "Image Radius:";
            // 
            // tbImageRadius
            // 
            this.tbImageRadius.Location = new System.Drawing.Point(374, 92);
            this.tbImageRadius.Name = "tbImageRadius";
            this.tbImageRadius.Size = new System.Drawing.Size(60, 20);
            this.tbImageRadius.TabIndex = 16;
            this.tbImageRadius.Text = "70";
            // 
            // btnCloudsTextureFile
            // 
            this.btnCloudsTextureFile.Enabled = false;
            this.btnCloudsTextureFile.Location = new System.Drawing.Point(438, 65);
            this.btnCloudsTextureFile.Name = "btnCloudsTextureFile";
            this.btnCloudsTextureFile.Size = new System.Drawing.Size(27, 20);
            this.btnCloudsTextureFile.TabIndex = 9;
            this.btnCloudsTextureFile.Text = "...";
            this.btnCloudsTextureFile.UseVisualStyleBackColor = true;
            this.btnCloudsTextureFile.Click += new System.EventHandler(this.btnCloudsTextureFile_Click);
            // 
            // btnPlanetTextureFile
            // 
            this.btnPlanetTextureFile.Enabled = false;
            this.btnPlanetTextureFile.Location = new System.Drawing.Point(438, 38);
            this.btnPlanetTextureFile.Name = "btnPlanetTextureFile";
            this.btnPlanetTextureFile.Size = new System.Drawing.Size(27, 20);
            this.btnPlanetTextureFile.TabIndex = 8;
            this.btnPlanetTextureFile.Text = "...";
            this.btnPlanetTextureFile.UseVisualStyleBackColor = true;
            this.btnPlanetTextureFile.Click += new System.EventHandler(this.btnPlanetTextureFile_Click);
            // 
            // lblCloudsTexture
            // 
            this.lblCloudsTexture.AutoSize = true;
            this.lblCloudsTexture.Location = new System.Drawing.Point(250, 69);
            this.lblCloudsTexture.Name = "lblCloudsTexture";
            this.lblCloudsTexture.Size = new System.Drawing.Size(42, 13);
            this.lblCloudsTexture.TabIndex = 7;
            this.lblCloudsTexture.Text = "Clouds:";
            // 
            // lblPlanetTexture
            // 
            this.lblPlanetTexture.AutoSize = true;
            this.lblPlanetTexture.Location = new System.Drawing.Point(252, 42);
            this.lblPlanetTexture.Name = "lblPlanetTexture";
            this.lblPlanetTexture.Size = new System.Drawing.Size(40, 13);
            this.lblPlanetTexture.TabIndex = 6;
            this.lblPlanetTexture.Text = "Planet:";
            // 
            // tbCloudsTextureFile
            // 
            this.tbCloudsTextureFile.Enabled = false;
            this.tbCloudsTextureFile.Location = new System.Drawing.Point(294, 66);
            this.tbCloudsTextureFile.Name = "tbCloudsTextureFile";
            this.tbCloudsTextureFile.Size = new System.Drawing.Size(140, 20);
            this.tbCloudsTextureFile.TabIndex = 5;
            // 
            // tbPlanetTextureFile
            // 
            this.tbPlanetTextureFile.Enabled = false;
            this.tbPlanetTextureFile.Location = new System.Drawing.Point(294, 39);
            this.tbPlanetTextureFile.Name = "tbPlanetTextureFile";
            this.tbPlanetTextureFile.Size = new System.Drawing.Size(140, 20);
            this.tbPlanetTextureFile.TabIndex = 4;
            // 
            // lblPlanetType
            // 
            this.lblPlanetType.AutoSize = true;
            this.lblPlanetType.Location = new System.Drawing.Point(23, 69);
            this.lblPlanetType.Name = "lblPlanetType";
            this.lblPlanetType.Size = new System.Drawing.Size(67, 13);
            this.lblPlanetType.TabIndex = 3;
            this.lblPlanetType.Text = "Planet Type:";
            // 
            // cbPlanetType
            // 
            this.cbPlanetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanetType.FormattingEnabled = true;
            this.cbPlanetType.Location = new System.Drawing.Point(96, 66);
            this.cbPlanetType.Name = "cbPlanetType";
            this.cbPlanetType.Size = new System.Drawing.Size(141, 21);
            this.cbPlanetType.TabIndex = 2;
            this.cbPlanetType.SelectedIndexChanged += new System.EventHandler(this.cbPlanetType_SelectedIndexChanged);
            // 
            // tbPlanetName
            // 
            this.tbPlanetName.Location = new System.Drawing.Point(96, 38);
            this.tbPlanetName.Name = "tbPlanetName";
            this.tbPlanetName.Size = new System.Drawing.Size(141, 20);
            this.tbPlanetName.TabIndex = 1;
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.AutoSize = true;
            this.lblPlanetName.Location = new System.Drawing.Point(19, 42);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(71, 13);
            this.lblPlanetName.TabIndex = 0;
            this.lblPlanetName.Text = "Planet Name:";
            // 
            // btnRenderImage
            // 
            this.btnRenderImage.Location = new System.Drawing.Point(492, 319);
            this.btnRenderImage.Name = "btnRenderImage";
            this.btnRenderImage.Size = new System.Drawing.Size(94, 23);
            this.btnRenderImage.TabIndex = 2;
            this.btnRenderImage.Text = "Render Single";
            this.btnRenderImage.UseVisualStyleBackColor = true;
            this.btnRenderImage.Click += new System.EventHandler(this.btnRenderImage_Click);
            // 
            // btnRenderFrames
            // 
            this.btnRenderFrames.Location = new System.Drawing.Point(492, 18);
            this.btnRenderFrames.Name = "btnRenderFrames";
            this.btnRenderFrames.Size = new System.Drawing.Size(94, 23);
            this.btnRenderFrames.TabIndex = 3;
            this.btnRenderFrames.Text = "Render Frames";
            this.btnRenderFrames.UseVisualStyleBackColor = true;
            this.btnRenderFrames.Click += new System.EventHandler(this.btnRenderFrames_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(492, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbortRender
            // 
            this.btnAbortRender.Enabled = false;
            this.btnAbortRender.Location = new System.Drawing.Point(492, 47);
            this.btnAbortRender.Name = "btnAbortRender";
            this.btnAbortRender.Size = new System.Drawing.Size(94, 23);
            this.btnAbortRender.TabIndex = 5;
            this.btnAbortRender.Text = "Abort Render";
            this.btnAbortRender.UseVisualStyleBackColor = true;
            this.btnAbortRender.Click += new System.EventHandler(this.btnAbortRender_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(491, 348);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLoadFrames
            // 
            this.btnLoadFrames.Location = new System.Drawing.Point(492, 108);
            this.btnLoadFrames.Name = "btnLoadFrames";
            this.btnLoadFrames.Size = new System.Drawing.Size(94, 23);
            this.btnLoadFrames.TabIndex = 14;
            this.btnLoadFrames.Text = "Load Frames";
            this.btnLoadFrames.UseVisualStyleBackColor = true;
            // 
            // btnSaveFrames
            // 
            this.btnSaveFrames.Enabled = false;
            this.btnSaveFrames.Location = new System.Drawing.Point(492, 137);
            this.btnSaveFrames.Name = "btnSaveFrames";
            this.btnSaveFrames.Size = new System.Drawing.Size(94, 23);
            this.btnSaveFrames.TabIndex = 15;
            this.btnSaveFrames.Text = "Save Frames";
            this.btnSaveFrames.UseVisualStyleBackColor = true;
            this.btnSaveFrames.Click += new System.EventHandler(this.btnSaveFrames_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(492, 377);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(93, 23);
            this.btnSaveImage.TabIndex = 16;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnSaveAnim
            // 
            this.btnSaveAnim.Enabled = false;
            this.btnSaveAnim.Location = new System.Drawing.Point(492, 166);
            this.btnSaveAnim.Name = "btnSaveAnim";
            this.btnSaveAnim.Size = new System.Drawing.Size(94, 23);
            this.btnSaveAnim.TabIndex = 17;
            this.btnSaveAnim.Text = "Save Anim";
            this.btnSaveAnim.UseVisualStyleBackColor = true;
            this.btnSaveAnim.Click += new System.EventHandler(this.btnSaveAnim_Click);
            // 
            // btnLoadAnim
            // 
            this.btnLoadAnim.Location = new System.Drawing.Point(492, 195);
            this.btnLoadAnim.Name = "btnLoadAnim";
            this.btnLoadAnim.Size = new System.Drawing.Size(94, 23);
            this.btnLoadAnim.TabIndex = 18;
            this.btnLoadAnim.Text = "Load Anim";
            this.btnLoadAnim.UseVisualStyleBackColor = true;
            this.btnLoadAnim.Click += new System.EventHandler(this.btnLoadAnim_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 485);
            this.Controls.Add(this.btnLoadAnim);
            this.Controls.Add(this.btnSaveAnim);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnSaveFrames);
            this.Controls.Add(this.btnLoadFrames);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAbortRender);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRenderFrames);
            this.Controls.Add(this.btnRenderImage);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar Body Images Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrames)).EndInit();
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRenderStatus;
        private System.Windows.Forms.Label lblRenderStatus;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.PictureBox pbFrames;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Label lblPlanetType;
        private System.Windows.Forms.ComboBox cbPlanetType;
        private System.Windows.Forms.TextBox tbPlanetName;
        private System.Windows.Forms.Label lblPlanetName;
        private System.Windows.Forms.Label lblCloudsTexture;
        private System.Windows.Forms.Label lblPlanetTexture;
        private System.Windows.Forms.TextBox tbCloudsTextureFile;
        private System.Windows.Forms.TextBox tbPlanetTextureFile;
        private System.Windows.Forms.Button btnCloudsTextureFile;
        private System.Windows.Forms.Button btnPlanetTextureFile;
        private System.Windows.Forms.Button btnRenderImage;
        private System.Windows.Forms.Button btnRenderFrames;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbortRender;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAnim;
        private System.Windows.Forms.PictureBox pbAnimation;
        private System.Windows.Forms.TrackBar tbarSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Label lblImagePixels;
        private System.Windows.Forms.TextBox tbImageRadius;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.RadioButton rdClockwise;
        private System.Windows.Forms.RadioButton rdCounter;
        private System.Windows.Forms.ProgressBar pbarRender;
        private System.Windows.Forms.Button btnLoadFrames;
        private System.Windows.Forms.Button btnSaveFrames;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lblSpaceColor;
        private System.Windows.Forms.Button btnBaseColor;
        private System.Windows.Forms.Label lblBaseColor;
        private System.Windows.Forms.Button btnGeneratorParams;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnSaveAnim;
        private System.Windows.Forms.Button btnLoadAnim;
        private System.Windows.Forms.Button btnRenderParameters;
    }
}

