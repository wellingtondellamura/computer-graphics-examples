using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class RGBImage: ICloneable
    {
        private RGB[,] pixels;

        public Int32 Width { get; set; }
        public Int32 Height { get; set; }

        public RGBImage(Int32 w, Int32 h)
        {
            Width = w;
            Height = h;
            pixels = new RGB[w, h];
        }

        public RGB GetPixel(Int32 x, Int32 y)
        {
            if ((x < 0) || x > Width || y < 0 || y > Height)
            {
                return new RGB(0, 0, 0);
            }
            return pixels[x, y];
        }

        public void SetPixel(Int32 x, Int32 y, RGB rgb)
        {
            if ((x < 0) || x > Width || y < 0 || y > Height)
            {
                return;
            }
            pixels[x, y] = rgb;
        }

        public unsafe Bitmap ToImage()
        {
            Rectangle r = new Rectangle(0, 0, Width, Height);
            Bitmap image = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            BitmapData imageData = image.LockBits(r, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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
                    RGB px = GetPixel(x, y);
                    row[rIndex] = px.R;
                    row[gIndex] = px.G;
                    row[bIndex] = px.B;
                }
            }

            image.UnlockBits(imageData);
            return image;
        }

        public static unsafe RGBImage FromImage(Bitmap image)
        {
            RGBImage img = new RGBImage(image.Width, image.Height);
            Rectangle r = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imageData = image.LockBits(r, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
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

                    img.SetPixel(x, y, new RGB(pixelR, pixelG, pixelB));
                }
            }

            image.UnlockBits(imageData);
            return img;
        }

        public object Clone()
        {
            RGBImage dolly = new RGBImage(this.Width, this.Height);
            for (int i = 0; i < dolly.Width; i++)
            {
                for (int j = 0; j < dolly.Height; j++)
                {
                    var p = this.GetPixel(i, j);
                    dolly.SetPixel(i, j, p);
                }

            }
            return dolly;
        }
    }

    public struct RGB
    {
        public Byte R;
        public Byte G;
        public Byte B;

        public RGB(Byte gray)
        {
            R = gray;
            G = gray;
            B = gray;
        }

        public RGB(Byte r, Byte g, Byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static RGB FromColor(Color c)
        {
            return new RGB(c.R, c.G, c.B);
        }

        public Color ToColor()
        {
            return Color.FromArgb(R, G, B);
        }

    }

}
