using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;

namespace SDImageFramework.Test
{
    [TestClass]
    public class ImageAnalyzerTests
    {
        [TestMethod]
        public void ImageHas90kPixels()
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(), @"assets/test-90k-pixels.png");
            var image = Image.FromFile(filename);

            var imageAnalyzer = new ImageAnalyzer(image);
            int pixelCount = imageAnalyzer.GetPixelsCount();

            Assert.AreEqual(pixelCount, 90000);
        }
    }
}
