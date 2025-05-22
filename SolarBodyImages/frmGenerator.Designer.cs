namespace SolarBodyImages
{
    partial class frmGenerator
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
            this.btnOK = new System.Windows.Forms.Button();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.lblCloudDensityPercent = new System.Windows.Forms.Label();
            this.tbarCloudDensity = new System.Windows.Forms.TrackBar();
            this.lblCloudDensity = new System.Windows.Forms.Label();
            this.numSeed = new System.Windows.Forms.NumericUpDown();
            this.numAltitude = new System.Windows.Forms.NumericUpDown();
            this.chkAltitudeColor = new System.Windows.Forms.CheckBox();
            this.lblInitialAltitude = new System.Windows.Forms.Label();
            this.rdoBumpmapLandOnly = new System.Windows.Forms.RadioButton();
            this.rdoBumpmap = new System.Windows.Forms.RadioButton();
            this.rdoNoBumpmap = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.lblSeed = new System.Windows.Forms.Label();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.btnGenerateClouds = new System.Windows.Forms.Button();
            this.btnGeneratePlanet = new System.Windows.Forms.Button();
            this.lblCloudsMap = new System.Windows.Forms.Label();
            this.pbCloudsMap = new System.Windows.Forms.PictureBox();
            this.lblMapImageDesc = new System.Windows.Forms.Label();
            this.lblPlanetMap = new System.Windows.Forms.Label();
            this.pbPlanetMap = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.lblCloudVolumePercent = new System.Windows.Forms.Label();
            this.tbarCloudVolume = new System.Windows.Forms.TrackBar();
            this.lblCloudVolume = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnNewSeedGenerate = new System.Windows.Forms.Button();
            this.gbParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCloudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltitude)).BeginInit();
            this.gbMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudsMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanetMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCloudVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(558, 425);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.btnNewSeedGenerate);
            this.gbParams.Controls.Add(this.lblCloudVolumePercent);
            this.gbParams.Controls.Add(this.tbarCloudVolume);
            this.gbParams.Controls.Add(this.lblCloudVolume);
            this.gbParams.Controls.Add(this.lblCloudDensityPercent);
            this.gbParams.Controls.Add(this.tbarCloudDensity);
            this.gbParams.Controls.Add(this.lblCloudDensity);
            this.gbParams.Controls.Add(this.numSeed);
            this.gbParams.Controls.Add(this.numAltitude);
            this.gbParams.Controls.Add(this.chkAltitudeColor);
            this.gbParams.Controls.Add(this.lblInitialAltitude);
            this.gbParams.Controls.Add(this.rdoBumpmapLandOnly);
            this.gbParams.Controls.Add(this.rdoBumpmap);
            this.gbParams.Controls.Add(this.rdoNoBumpmap);
            this.gbParams.Controls.Add(this.lblColor);
            this.gbParams.Controls.Add(this.cbColor);
            this.gbParams.Controls.Add(this.btnNewSeed);
            this.gbParams.Controls.Add(this.lblSeed);
            this.gbParams.Location = new System.Drawing.Point(12, 12);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(540, 204);
            this.gbParams.TabIndex = 1;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Map Generator Parameters:";
            // 
            // lblCloudDensityPercent
            // 
            this.lblCloudDensityPercent.AutoSize = true;
            this.lblCloudDensityPercent.Location = new System.Drawing.Point(235, 158);
            this.lblCloudDensityPercent.Name = "lblCloudDensityPercent";
            this.lblCloudDensityPercent.Size = new System.Drawing.Size(33, 13);
            this.lblCloudDensityPercent.TabIndex = 17;
            this.lblCloudDensityPercent.Text = "(25%)";
            // 
            // tbarCloudDensity
            // 
            this.tbarCloudDensity.AutoSize = false;
            this.tbarCloudDensity.Location = new System.Drawing.Point(101, 158);
            this.tbarCloudDensity.Maximum = 100;
            this.tbarCloudDensity.Minimum = 1;
            this.tbarCloudDensity.Name = "tbarCloudDensity";
            this.tbarCloudDensity.Size = new System.Drawing.Size(139, 40);
            this.tbarCloudDensity.TabIndex = 16;
            this.tbarCloudDensity.TickFrequency = 10;
            this.tbarCloudDensity.Value = 25;
            this.tbarCloudDensity.ValueChanged += new System.EventHandler(this.tbarCloudDensity_ValueChanged);
            // 
            // lblCloudDensity
            // 
            this.lblCloudDensity.AutoSize = true;
            this.lblCloudDensity.Location = new System.Drawing.Point(20, 158);
            this.lblCloudDensity.Name = "lblCloudDensity";
            this.lblCloudDensity.Size = new System.Drawing.Size(75, 13);
            this.lblCloudDensity.TabIndex = 15;
            this.lblCloudDensity.Text = "Cloud Density:";
            // 
            // numSeed
            // 
            this.numSeed.DecimalPlaces = 8;
            this.numSeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.numSeed.Location = new System.Drawing.Point(104, 28);
            this.numSeed.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeed.Name = "numSeed";
            this.numSeed.Size = new System.Drawing.Size(89, 20);
            this.numSeed.TabIndex = 14;
            // 
            // numAltitude
            // 
            this.numAltitude.DecimalPlaces = 2;
            this.numAltitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAltitude.Location = new System.Drawing.Point(104, 106);
            this.numAltitude.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAltitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147418112});
            this.numAltitude.Name = "numAltitude";
            this.numAltitude.Size = new System.Drawing.Size(89, 20);
            this.numAltitude.TabIndex = 13;
            this.numAltitude.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147352576});
            // 
            // chkAltitudeColor
            // 
            this.chkAltitudeColor.AutoSize = true;
            this.chkAltitudeColor.Checked = true;
            this.chkAltitudeColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAltitudeColor.Location = new System.Drawing.Point(101, 135);
            this.chkAltitudeColor.Name = "chkAltitudeColor";
            this.chkAltitudeColor.Size = new System.Drawing.Size(127, 17);
            this.chkAltitudeColor.TabIndex = 12;
            this.chkAltitudeColor.Text = "Vary Color on Altitude";
            this.chkAltitudeColor.UseVisualStyleBackColor = true;
            // 
            // lblInitialAltitude
            // 
            this.lblInitialAltitude.AutoSize = true;
            this.lblInitialAltitude.Location = new System.Drawing.Point(26, 108);
            this.lblInitialAltitude.Name = "lblInitialAltitude";
            this.lblInitialAltitude.Size = new System.Drawing.Size(72, 13);
            this.lblInitialAltitude.TabIndex = 11;
            this.lblInitialAltitude.Text = "Initial Altitude:";
            // 
            // rdoBumpmapLandOnly
            // 
            this.rdoBumpmapLandOnly.AutoSize = true;
            this.rdoBumpmapLandOnly.Checked = true;
            this.rdoBumpmapLandOnly.Location = new System.Drawing.Point(364, 83);
            this.rdoBumpmapLandOnly.Name = "rdoBumpmapLandOnly";
            this.rdoBumpmapLandOnly.Size = new System.Drawing.Size(123, 17);
            this.rdoBumpmapLandOnly.TabIndex = 9;
            this.rdoBumpmapLandOnly.TabStop = true;
            this.rdoBumpmapLandOnly.Text = "Bumpmap Land Only";
            this.rdoBumpmapLandOnly.UseVisualStyleBackColor = true;
            // 
            // rdoBumpmap
            // 
            this.rdoBumpmap.AutoSize = true;
            this.rdoBumpmap.Location = new System.Drawing.Point(209, 83);
            this.rdoBumpmap.Name = "rdoBumpmap";
            this.rdoBumpmap.Size = new System.Drawing.Size(140, 17);
            this.rdoBumpmap.TabIndex = 8;
            this.rdoBumpmap.Text = "Bumpmap Land && Water";
            this.rdoBumpmap.UseVisualStyleBackColor = true;
            // 
            // rdoNoBumpmap
            // 
            this.rdoNoBumpmap.AutoSize = true;
            this.rdoNoBumpmap.Location = new System.Drawing.Point(104, 83);
            this.rdoNoBumpmap.Name = "rdoNoBumpmap";
            this.rdoNoBumpmap.Size = new System.Drawing.Size(89, 17);
            this.rdoNoBumpmap.TabIndex = 7;
            this.rdoNoBumpmap.Text = "No Bumpmap";
            this.rdoNoBumpmap.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(40, 59);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color Map:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(104, 56);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 5;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(197, 26);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 22);
            this.btnNewSeed.TabIndex = 2;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(20, 30);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(78, 13);
            this.lblSeed.TabIndex = 1;
            this.lblSeed.Text = "Random Seed:";
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.btnGenerateClouds);
            this.gbMap.Controls.Add(this.btnGeneratePlanet);
            this.gbMap.Controls.Add(this.lblCloudsMap);
            this.gbMap.Controls.Add(this.pbCloudsMap);
            this.gbMap.Controls.Add(this.lblMapImageDesc);
            this.gbMap.Controls.Add(this.lblPlanetMap);
            this.gbMap.Controls.Add(this.pbPlanetMap);
            this.gbMap.Location = new System.Drawing.Point(11, 222);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(541, 226);
            this.gbMap.TabIndex = 2;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Current Generated Maps:";
            // 
            // btnGenerateClouds
            // 
            this.btnGenerateClouds.Location = new System.Drawing.Point(278, 172);
            this.btnGenerateClouds.Name = "btnGenerateClouds";
            this.btnGenerateClouds.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateClouds.TabIndex = 6;
            this.btnGenerateClouds.Text = "Generate";
            this.btnGenerateClouds.UseVisualStyleBackColor = true;
            this.btnGenerateClouds.Click += new System.EventHandler(this.btnGenerateClouds_Click);
            // 
            // btnGeneratePlanet
            // 
            this.btnGeneratePlanet.Location = new System.Drawing.Point(12, 172);
            this.btnGeneratePlanet.Name = "btnGeneratePlanet";
            this.btnGeneratePlanet.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePlanet.TabIndex = 5;
            this.btnGeneratePlanet.Text = "Generate";
            this.btnGeneratePlanet.UseVisualStyleBackColor = true;
            this.btnGeneratePlanet.Click += new System.EventHandler(this.btnGeneratePlanet_Click);
            // 
            // lblCloudsMap
            // 
            this.lblCloudsMap.AutoSize = true;
            this.lblCloudsMap.Location = new System.Drawing.Point(275, 25);
            this.lblCloudsMap.Name = "lblCloudsMap";
            this.lblCloudsMap.Size = new System.Drawing.Size(98, 13);
            this.lblCloudsMap.TabIndex = 4;
            this.lblCloudsMap.Text = "Clouds Map Image:";
            // 
            // pbCloudsMap
            // 
            this.pbCloudsMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCloudsMap.Location = new System.Drawing.Point(278, 41);
            this.pbCloudsMap.Name = "pbCloudsMap";
            this.pbCloudsMap.Size = new System.Drawing.Size(250, 125);
            this.pbCloudsMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloudsMap.TabIndex = 3;
            this.pbCloudsMap.TabStop = false;
            // 
            // lblMapImageDesc
            // 
            this.lblMapImageDesc.AutoSize = true;
            this.lblMapImageDesc.Location = new System.Drawing.Point(9, 198);
            this.lblMapImageDesc.Name = "lblMapImageDesc";
            this.lblMapImageDesc.Size = new System.Drawing.Size(405, 13);
            this.lblMapImageDesc.TabIndex = 2;
            this.lblMapImageDesc.Text = "(map images are always 1000 pixels wide by 500 pixels high - this image is a prev" +
    "iew)";
            // 
            // lblPlanetMap
            // 
            this.lblPlanetMap.AutoSize = true;
            this.lblPlanetMap.Location = new System.Drawing.Point(9, 25);
            this.lblPlanetMap.Name = "lblPlanetMap";
            this.lblPlanetMap.Size = new System.Drawing.Size(96, 13);
            this.lblPlanetMap.TabIndex = 1;
            this.lblPlanetMap.Text = "Planet Map Image:";
            // 
            // pbPlanetMap
            // 
            this.pbPlanetMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlanetMap.Location = new System.Drawing.Point(12, 41);
            this.pbPlanetMap.Name = "pbPlanetMap";
            this.pbPlanetMap.Size = new System.Drawing.Size(250, 125);
            this.pbPlanetMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanetMap.TabIndex = 0;
            this.pbPlanetMap.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(558, 110);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(558, 21);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnDefaults.TabIndex = 6;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // lblCloudVolumePercent
            // 
            this.lblCloudVolumePercent.AutoSize = true;
            this.lblCloudVolumePercent.Location = new System.Drawing.Point(498, 158);
            this.lblCloudVolumePercent.Name = "lblCloudVolumePercent";
            this.lblCloudVolumePercent.Size = new System.Drawing.Size(33, 13);
            this.lblCloudVolumePercent.TabIndex = 20;
            this.lblCloudVolumePercent.Text = "(40%)";
            // 
            // tbarCloudVolume
            // 
            this.tbarCloudVolume.AutoSize = false;
            this.tbarCloudVolume.Location = new System.Drawing.Point(364, 158);
            this.tbarCloudVolume.Maximum = 100;
            this.tbarCloudVolume.Minimum = 1;
            this.tbarCloudVolume.Name = "tbarCloudVolume";
            this.tbarCloudVolume.Size = new System.Drawing.Size(139, 40);
            this.tbarCloudVolume.TabIndex = 19;
            this.tbarCloudVolume.TickFrequency = 10;
            this.tbarCloudVolume.Value = 40;
            // 
            // lblCloudVolume
            // 
            this.lblCloudVolume.AutoSize = true;
            this.lblCloudVolume.Location = new System.Drawing.Point(290, 158);
            this.lblCloudVolume.Name = "lblCloudVolume";
            this.lblCloudVolume.Size = new System.Drawing.Size(75, 13);
            this.lblCloudVolume.TabIndex = 18;
            this.lblCloudVolume.Text = "Cloud Volume:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(558, 50);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 7;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            // 
            // btnNewSeedGenerate
            // 
            this.btnNewSeedGenerate.Location = new System.Drawing.Point(278, 26);
            this.btnNewSeedGenerate.Name = "btnNewSeedGenerate";
            this.btnNewSeedGenerate.Size = new System.Drawing.Size(135, 22);
            this.btnNewSeedGenerate.TabIndex = 21;
            this.btnNewSeedGenerate.Text = "New Seed && Generate";
            this.btnNewSeedGenerate.UseVisualStyleBackColor = true;
            this.btnNewSeedGenerate.Click += new System.EventHandler(this.btnNewSeedGenerate_Click);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 458);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planet & Cloud Generator Parameters";
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCloudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltitude)).EndInit();
            this.gbMap.ResumeLayout(false);
            this.gbMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudsMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanetMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCloudVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Label lblInitialAltitude;
        private System.Windows.Forms.RadioButton rdoBumpmapLandOnly;
        private System.Windows.Forms.RadioButton rdoBumpmap;
        private System.Windows.Forms.RadioButton rdoNoBumpmap;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.GroupBox gbMap;
        private System.Windows.Forms.Label lblMapImageDesc;
        private System.Windows.Forms.Label lblPlanetMap;
        private System.Windows.Forms.PictureBox pbPlanetMap;
        private System.Windows.Forms.NumericUpDown numAltitude;
        private System.Windows.Forms.CheckBox chkAltitudeColor;
        private System.Windows.Forms.Label lblCloudsMap;
        private System.Windows.Forms.PictureBox pbCloudsMap;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnGeneratePlanet;
        private System.Windows.Forms.Button btnGenerateClouds;
        private System.Windows.Forms.NumericUpDown numSeed;
        private System.Windows.Forms.TrackBar tbarCloudDensity;
        private System.Windows.Forms.Label lblCloudDensity;
        private System.Windows.Forms.Label lblCloudDensityPercent;
        private System.Windows.Forms.Label lblCloudVolumePercent;
        private System.Windows.Forms.TrackBar tbarCloudVolume;
        private System.Windows.Forms.Label lblCloudVolume;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnNewSeedGenerate;
    }
}