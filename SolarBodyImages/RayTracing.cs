using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace SolarBodyImages
{
	public class RTPlanet
	{
        // Public enums
        public enum enumLightingSource
        {
            Center, 
            North, 
            NorthEast, 
            East, 
            SouthEast, 
            South, 
            SouthWest, 
            West, 
            NorthWest
        };

	    public enum enumCloudSpeed
	    {
	        Slower,
	        Same,
	        Faster
	    };

        // Private vars for planet
        private int _intRadius = 125;
        private Bitmap _bmpPlanetTex;
        private Bitmap _bmpCloudsTex;
        private Bitmap _bmpGlowTex;
		private double _longitude = 0;
		private bool _shadows = true;
	    private System.Drawing.Color _shadowcolor = Color.Black;
        private System.Drawing.Color _basecolor = Color.White;
        private System.Drawing.Color _glowhighcolor = Color.LightBlue;
        private System.Drawing.Color _glowlowcolor = Color.DarkBlue;
        private enumLightingSource _lightingsource = enumLightingSource.NorthWest;
	    private enumCloudSpeed _cloudspeed = enumCloudSpeed.Same;
        private double _tiltx = 1.5;
        private double _tilty = -2.5;
	    private int _shadowstrength = 150;
        private double _glowpercent = 0.96;
	    private bool _overrideColor = false;
	    private bool _glowOffset = false;
	    private bool _glowPlanetColor = false;

	    // Private constants
		const double theta0 = 0.0;
		const double theta1 = 2.0 * Math.PI;
		const double phi0 = 0.0;
        const double phi1 = Math.PI;

		// Properties
		public int Radius
		{
			get { return _intRadius; }
            set { _intRadius = value; }
		}

		public Bitmap PlanetTexture
		{
			get { return _bmpPlanetTex; }
			set { _bmpPlanetTex = value; }
		}

		public Bitmap CloudsTexture
		{
			get { return _bmpCloudsTex; }
			set { _bmpCloudsTex = value; }
		}

		public double Longitude
		{
			get { return _longitude; }
			set { _longitude = value; }
		}

		public bool Shadows
		{
			get { return _shadows; }
			set { _shadows = value; }
		}

	    public bool OverrideColor
	    {
	        get { return _overrideColor; }
	        set { _overrideColor = value; }
	    }

	    public bool GlowOffset
	    {
	        get { return _glowOffset; }
	        set { _glowOffset = value; }
	    }

	    public bool GlowPlanetColor
	    {
	        get { return _glowPlanetColor; }
	        set { _glowPlanetColor = value; }
	    }

	    public System.Drawing.Color ShadowColor
        {
            get { return _shadowcolor; }
            set { _shadowcolor = value; }
        }

        public System.Drawing.Color BaseColor
        {
            get { return _basecolor; }
            set { _basecolor = value; }
        }

        public System.Drawing.Color GlowHighColor
        {
            get { return _glowhighcolor; }
            set { _glowhighcolor = value; }
        }

        public System.Drawing.Color GlowLowColor
        {
            get { return _glowlowcolor; }
            set { _glowlowcolor = value; }
        }

        public enumLightingSource LightingSource
        {
            get { return _lightingsource; }
            set { _lightingsource = value; }
        }

	    public enumCloudSpeed CloudSpeed
	    {
            get { return _cloudspeed; }
            set { _cloudspeed = value; }
	    }

        public double TiltX
        {
            get { return _tiltx; }
            set { _tiltx = value; }
        }

        public double TiltY
        {
            get { return _tilty; }
            set { _tilty = value; }
        }

        public int ShadowStrength
        {
            get { return _shadowstrength; }
            set { _shadowstrength = value; }
        }

        public double GlowPercent
        {
            get { return _glowpercent; }
            set { _glowpercent = value; }
        }

        // Class constructor - requires planet radius (in pixels)
		public RTPlanet ()
		{
		}

	    // Private methods
		private double MapCoordinate(double i1, double i2, double w1,double w2, double p)
		{
			return ((p - i1) / (i2 - i1)) * (w2 - w1) + w1;
		}

		private void RotX(double angle, ref double y, ref double z)
		{
			double y1 = y * System.Math.Cos(angle) - z * System.Math.Sin(angle);
			double z1 = y * System.Math.Sin(angle) + z * System.Math.Cos(angle);
			y = y1;
			z = z1;
		}
		
		private void RotY(double angle, ref double x, ref double z)
		{
			double x1 = x * System.Math.Cos(angle) - z * System.Math.Sin(angle);
			double z1 = x * System.Math.Sin(angle) + z * System.Math.Cos(angle);
			x = x1;
			z = z1;
		}

        public void ClearGlowImage()
        {
            _bmpGlowTex = null;
        }

        public System.Drawing.Color GetAverageColor()
        {
            Int32 iBigR = 0;
            Int32 iBigG = 0;
            Int32 iBigB = 0;
            Int32 iNumPixels = 0;
            for (int x = 0; x < _bmpPlanetTex.Width; x++)
            {
                for (int y = 0; y < _bmpPlanetTex.Height; y++)
                {
                    Color colorPixel = _bmpPlanetTex.GetPixel(x, y);
                    iBigR = iBigR + colorPixel.R;
                    iBigG = iBigG + colorPixel.G;
                    iBigB = iBigB + colorPixel.B;
                    iNumPixels++;
                }
            }
            System.Drawing.Color colorNew = Color.FromArgb(255, iBigR/iNumPixels, iBigG/iNumPixels, iBigB/iNumPixels);
            return colorNew;
        }

        public void CreateGlowImage()
        {
            // Start with planet texture, and we work with it at it's native resolution first
            double radius = _bmpPlanetTex.Height / 2;
            int width = _bmpPlanetTex.Width;
            int height = _bmpPlanetTex.Height;
            int xcentre = width / 2;
            int ycentre = height / 2;

            // Glow colors
            System.Drawing.Color colorHigh = _glowhighcolor;
            System.Drawing.Color colorLow = _glowlowcolor;
            if (_glowPlanetColor)
            {
                System.Drawing.Color colorAverage = GetAverageColor();
                colorHigh = System.Windows.Forms.ControlPaint.Light(colorAverage, 1.3f);
                colorLow = colorAverage;
            }

            // Create working bitmap in 32bpp and graphics object for drawing - the extra 3 pixels are to make up for the mapping precision loss
            Bitmap bmpNew = new Bitmap(width+3, height+3, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmpNew);

            // Loop through vertical pixels
            for (int i = 0; i < _bmpPlanetTex.Width; i++)
            {
                // Loop through horizontal pixels
                for (int j = 0; j < _bmpPlanetTex.Height; j++)
                {
                    // Map the angles from image coordinates longitude
                    double theta = MapCoordinate(0.0, width - 1, theta1, theta0, i);

                    // Latitude
                    double phi = MapCoordinate(0.0, height - 1, phi0, phi1, j);

                    // Find the cartesian coordinates of this point
                    double x = radius * Math.Sin(phi) * Math.Cos(theta);
                    double y = radius * Math.Sin(phi) * Math.Sin(theta);
                    double z = radius * Math.Cos(phi);

                    // Plot only positive points (meaning visible on the sphere/planet from this angle)
                    if (z >= 0)
                    {
                        // Create new brush using color for base of glow
                        Brush brush = new SolidBrush(colorHigh);

                        // New x/y for ray traced image
                        int ix = (int)x + xcentre;
                        int iy = (int)y + ycentre;

                        // Draw rect using brush and dispose
                        graphics.FillRectangle(brush, ix, iy, 3, 3);

                        // New alpha based on lighting source
                        //int iAlpha = 200 - (int)(z);
                        int iAlpha = 150 - (int)(z);

                        // Make sure alpha is between 0 and 255
                        if (iAlpha < 0)
                            iAlpha = 0;
                        if (iAlpha > 255)
                            iAlpha = 255;

                        // Create new brush using proper alpha (color is black for shadows)
                        brush = new SolidBrush(Color.FromArgb(iAlpha, colorLow));

                        // Draw rect using brush and dispose
                        graphics.FillRectangle(brush, ix, iy, 3, 3);

                        // Dispose of brush
                        brush.Dispose();
                    }
                }
            }

            // Calculate proper sizes for resized image and keep aspect ratio of original texture
            int newHeight = _intRadius * 2;
            int newWidth = (int)(newHeight * (width / height));

            // Resize using high quality to an image that matches the specified radius
            Bitmap bmpResize = ImageUtilities.ResizeImage(bmpNew, newWidth, newHeight);

            // Create new bitmap for result - based on specified size (radius)
            Bitmap bmpResult = new Bitmap(_intRadius * 2, _intRadius * 2, PixelFormat.Format32bppArgb);

            // Create graphics object from bitmap and draw the resized image on it
            graphics = Graphics.FromImage(bmpResult);
            graphics.DrawImage(bmpResize, -1 * (_intRadius), 0); // altered x location to match sphere radius

            // Return image result
            _bmpGlowTex = bmpResult;
        }
		
		// Public methods
		public Bitmap CreateImage()
		{
			// Start with planet texture, and we work with it at it's native resolution first
			double radius = _bmpPlanetTex.Height / 2;
			int width = _bmpPlanetTex.Width;
			int height = _bmpPlanetTex.Height;
			int xcentre = width / 2;
			int ycentre = height / 2;

            // Create working bitmap in 32bpp and graphics object for drawing - the extra 3 pixels are to make up for the mapping precision loss
			Bitmap bmpNew = new Bitmap(width+3, height+3, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bmpNew);

            // Loop through vertical pixels
			for (int i = 0; i < _bmpPlanetTex.Width; i++)
			{
				// Loop through horizontal pixels
				for (int j = 0; j < _bmpPlanetTex.Height; j++)
				{
					// Map the angles from image coordinates longitude
					double theta = MapCoordinate(0.0, width - 1, theta1, theta0, i);

					// Check for specified longitude
					if (_longitude != 0)
					{
						theta += _longitude;
					}

					// Latitude
					double phi = MapCoordinate(0.0, height - 1, phi0, phi1, j);

					// Find the cartesian coordinates of this point
					double x = radius * Math.Sin(phi) * Math.Cos(theta);
					double y = radius * Math.Sin(phi) * Math.Sin(theta);
					double z = radius * Math.Cos(phi);

					// Apply rotation around X and Y axis to reposition the sphere (tilt)
					RotX(_tiltx, ref y, ref z);
					RotY(_tilty, ref x, ref z);

					// Plot only positive points (meaning visible on the sphere/planet from this angle)
					if (z >= 0)
					{
						// Get color at pixel from planet
						Color colorPlanet = _bmpPlanetTex.GetPixel(i, j);

                        // Check for override
                        if (OverrideColor)
                            colorPlanet = _basecolor;

						// Create new brush using color
						Brush brush = new SolidBrush(colorPlanet);

						// New x/y for ray traced image
                        int ix = (int)x + xcentre;
                        int iy = (int)y + ycentre;

						// Draw rect using brush and dispose
						graphics.FillRectangle(brush, ix, iy, 3, 3);







                        if (_bmpCloudsTex != null)
                        {
                            // Get color at pixel from clouds (for use as alpha)
                            Color colorClouds = _bmpCloudsTex.GetPixel(i, j);

                            // Create new brush using proper alpha (color is white for clouds)
                            //brush = new SolidBrush(Color.FromArgb(255 - colorClouds.R, Color.White));
                            brush = new SolidBrush(Color.FromArgb(colorClouds.R, Color.White));

                            // Draw rect using brush and dispose
                            graphics.FillRectangle(brush, ix, iy, 3, 3);
                        }






						// Shadow for lighting
						if (_shadows)
						{
							// New alpha based on lighting source
                            int iAlpha = 0;
                            switch (_lightingsource)
                            {
                                case enumLightingSource.Center:
                                    iAlpha = _shadowstrength - (int)(z);
                                    break;
                                case enumLightingSource.North:
                                    iAlpha = _shadowstrength - (int)(z - y);
                                    break;
                                case enumLightingSource.NorthEast:
                                    iAlpha = _shadowstrength - (int)(z + x - y);
                                    break;
                                case enumLightingSource.East:
                                    iAlpha = _shadowstrength - (int)(z + x);
                                    break;
                                case enumLightingSource.SouthEast:
                                    iAlpha = _shadowstrength - (int)(z + x + y);
                                    break;
                                case enumLightingSource.South:
                                    iAlpha = _shadowstrength - (int)(z + y);
                                    break;
                                case enumLightingSource.SouthWest:
                                    iAlpha = _shadowstrength - (int)(z - x + y);
                                    break;
                                case enumLightingSource.West:
                                    iAlpha = _shadowstrength - (int)(z - x);
                                    break;
                                case enumLightingSource.NorthWest:
                                    iAlpha = _shadowstrength - (int)(z - x - y);
                                    break;
                            }

                            // Make sure alpha is between 0 and 255
                            if (iAlpha < 0)
                                iAlpha = 0;
                            if (iAlpha > 255)
                                iAlpha = 255;

							// Create new brush using proper alpha (color is black for shadows)
                            brush = new SolidBrush(Color.FromArgb(iAlpha, _shadowcolor));

							// Draw rect using brush and dispose
							graphics.FillRectangle(brush, ix, iy, 3, 3);
						}
						
						// Dispose of brush
						brush.Dispose();
					}
				}
			}

			// Calculate proper sizes for resized image and keep aspect ratio of original texture
			int newHeight = _intRadius * 2;
			int newWidth = (int)(newHeight * ((double)width/(double)height));

            // Create new bitmap based on specified size
            Bitmap bmpResult = new Bitmap(_intRadius * 2, _intRadius * 2, PixelFormat.Format32bppArgb);

            // Resize using high quality to an image that matches the specified radius
			Bitmap bmpResize = ImageUtilities.ResizeImage (bmpNew, newWidth, newHeight);

            // Create graphics object from bitmap and draw the resized image on it
            graphics = Graphics.FromImage(bmpResult);
		    //int iCalcLeft = -1*(_intRadius);
		    int iCalcLeft = -1*((bmpResize.Width - bmpResize.Height)/2);
            graphics.DrawImage(bmpResize, iCalcLeft, 0); // altered x location to match sphere radius

            // Now handle the glow effect and resizing of the image if specified
            Bitmap bmpFinal = new Bitmap(_intRadius * 2, _intRadius * 2, PixelFormat.Format32bppArgb);

            // Handle glow effect
            if (_bmpGlowTex != null)
            {
                // Start with glow effect bitmap
                graphics = Graphics.FromImage(bmpFinal);
                graphics.DrawImage(_bmpGlowTex, 0, 0);

                // Resize planet bitmap
                int newSize = (int)Math.Round(bmpResult.Width * _glowpercent, 0);
                Bitmap bmpGlowResize = ImageUtilities.ResizeImage(bmpResult, newSize, newSize);

                // Create graphics object from bitmap and draw the resized image on it
                int iX = (bmpFinal.Width - bmpGlowResize.Width) / 2;
                int iY = (bmpFinal.Height - bmpGlowResize.Height) / 2;
                graphics.DrawImage(bmpGlowResize, iX, iY);
            }
            else
            {
                // Just return the standard (non-resized) bitmap
                graphics = Graphics.FromImage(bmpFinal);
                graphics.DrawImage(bmpResult, 0, 0);
            }

            // Return image result
            return bmpFinal;
		}
	}
}

