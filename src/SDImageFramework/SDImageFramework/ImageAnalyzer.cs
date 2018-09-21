using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SDImageFramework
{
    /// <summary>
    /// Class that provides methods to analyze images
    /// </summary>
    public class ImageAnalyzer
    {
        /// <summary>
        /// Image object to be analyzed
        /// </summary>
        private Image image;

        public ImageAnalyzer(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException("image");
            }

            this.image = image;
        }

        /// <summary>
        /// Returns the numbers of pixels in the current loaded image
        /// </summary>
        /// <returns></returns>
        public int GetPixelsCount()
        {
            return this.image.Width * this.image.Height;
        }
    }
}
