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
    public class Grayscale3
    {
        public unsafe Image Process(Image img)
        {
            Bitmap image = (Bitmap)img.Clone();
            
            Rectangle r = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(r, ImageLockMode.ReadWrite, 
                                        PixelFormat.Format24bppRgb);
            int bytesPerPixel = 3;

            byte* scan0 = (byte*)imageData.Scan0.ToPointer();
            int stride = imageData.Stride;
            
            for (int y = 0; y < imageData.Height; y++)
            {
                byte* row = scan0 + (y * stride);

                for (int x = 0; x < imageData.Width; x++)
                {
                    int bIndex = x * bytesPerPixel;
                    int gIndex = bIndex + 1;
                    int rIndex = bIndex + 2;

                    byte pixelR = row[rIndex];
                    byte pixelG = row[gIndex];
                    byte pixelB = row[bIndex];

                    byte g = (byte)(pixelR * 0.3 + pixelG * 0.59 + pixelB * 0.11);

                    row[rIndex] = row[gIndex] = row[bIndex] = g;
                }
            }

            image.UnlockBits(imageData);
            return image;
        }
    }
}
