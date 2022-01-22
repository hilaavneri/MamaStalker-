using Common;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace HandleImage
{
    public class ImageWriter : IDataWriter
    {
        public byte[] GetData()
        {
            try
            {
                var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                               Screen.PrimaryScreen.Bounds.Height,
                                               PixelFormat.Format32bppArgb);

                // Create a graphics object from the bitmap.
                var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                // Take the screenshot from the upper left corner to the right bottom corner.
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                            Screen.PrimaryScreen.Bounds.Y,
                                            0,
                                            0,
                                            Screen.PrimaryScreen.Bounds.Size,
                                            CopyPixelOperation.SourceCopy);
                return ImageToByte(bmpScreenshot);

            }
            catch (Exception e)
            {
                Console.WriteLine("GetData");
                throw;
            }
        }

        private byte[] ImageToByte(Image iImage)
        {

            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, ImageFormat.Png);
           
            return mMemoryStream.ToArray();
        }
    }
}
