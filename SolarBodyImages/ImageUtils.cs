using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SolarBodyImages
{
	public static class ImageUtilities
	{
        public static System.Drawing.Bitmap LoadImage(string sFilename)
        {
            // Load existing planet bitmap - use stream to control the file lock
            FileStream bmpFile = File.OpenRead(sFilename);
            Bitmap bmpLoaded = new Bitmap(bmpFile);
            bmpFile.Close();
            bmpFile.Dispose();
            return bmpLoaded;
        }

		public static System.Drawing.Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
		{
			// A holder for the result
			Bitmap result = new Bitmap(width, height);

			// Set the resolutions the same to avoid cropping due to resolution differences
			if (image.HorizontalResolution != 0)
				result.SetResolution (image.HorizontalResolution, image.VerticalResolution);
			else
				result.SetResolution(image.Width, image.Height);

			// Use a graphics object to draw the resized image into the bitmap
			using (Graphics graphics = Graphics.FromImage(result))
			{
				// Set the resize quality modes to high quality
				graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

				// Draw the image into the target bitmap
				graphics.DrawImage(image, 0, 0, result.Width, result.Height);
			}
			
			// Return the resulting bitmap
			return result;
		}
		
	}
}

