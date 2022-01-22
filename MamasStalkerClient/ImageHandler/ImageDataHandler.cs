using MamasStalker.Common;
using System;
using System.Drawing;
using System.IO;

namespace ImageHandler
{
    public class ImageDataHandler : IDataHandler
    {
        public void HandleData(int bytesRec, byte[] data)
        {
            string imageName = "Image-" + System.DateTime.Now.Ticks + ".png";
            Console.WriteLine("length: " +data.Length );
            if (bytesRec > 0)
            {
                
                    //MemoryStream ms = new MemoryStream(data,0,data.Length);
                try
                {
                    using (var ms = new MemoryStream(data))
                    {
                        Image img = Image.FromStream(ms,true);
                        
                        //System.Console.WriteLine(img.ToString());
                        img.Save(imageName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
             
                
            }
        }
    }
}
