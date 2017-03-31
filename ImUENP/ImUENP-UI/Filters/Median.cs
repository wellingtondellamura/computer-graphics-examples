using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class Median
    {
        public static Byte DEFAULT_WINDOW = 3;
        
        public Byte Window { get; set; }

        public Median() : this(DEFAULT_WINDOW) { }

        public Median(Byte window)
        {
            Window = window;
        }

        public RGBImage Process(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();//grayscale
            //if (image.Type != ColorType.Grayscale)
            //    return img;
            int offset = Window / 2;
            for (int i = offset; i < image.Width- offset; i++)
            {
                for (int j = offset; j < image.Height- offset; j++)
                {
                    List<int> pixels = new List<int>();
                    for (int x = i-offset; x<=i+offset; x++)
                    {
                        for (int y = j - offset; y <= j + offset; y++)
                        {
                            var p = image.GetPixel(x, y);
                            pixels.Add(p.R);
                        }
                    }
                    pixels.Sort();
                    int g = pixels[pixels.Count/2 + 1];
                    image.SetPixel(i,j, new RGB((Byte) g));
                }
            }
            return image;
        }
    }
}
