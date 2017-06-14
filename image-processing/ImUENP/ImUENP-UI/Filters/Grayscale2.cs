using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class Grayscale2
    {
        public Image Process(Image img)
        {
            Bitmap image = (Bitmap)img.Clone();
            var r = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(r, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] imageBytes = new byte[Math.Abs(imageData.Stride) * image.Height];
            IntPtr scan0 = imageData.Scan0;
        
            Marshal.Copy(scan0, imageBytes, 0, imageBytes.Length);
            for (int i = 0; i < imageBytes.Length-1; i += 3)
            {
                byte pixelB = imageBytes[i];
                byte pixelG = imageBytes[i + 1];
                byte pixelR = imageBytes[i + 2];

                var g = (pixelR * 0.3 + pixelG * 0.59 + pixelB * 0.11);

                imageBytes[i] = imageBytes[i + 1] = imageBytes[i + 2] = (byte) g;
            }

            Marshal.Copy(imageBytes, 0, scan0, imageBytes.Length);

            image.UnlockBits(imageData);
           
            return image;
        }
    }
}
