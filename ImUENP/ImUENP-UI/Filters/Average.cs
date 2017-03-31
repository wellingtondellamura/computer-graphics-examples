using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class Average
    {
        public static Byte DEFAULT_WINDOW = 3;
        
        public Byte Window { get; set; }

        public Average() : this(DEFAULT_WINDOW) { }

        public Average(Byte window)
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
                    int media = 0;
                    for (int x = i-offset; x<=i+offset; x++)
                    {
                        for (int y = j - offset; y <= j + offset; y++)
                        {
                            var p = image.GetPixel(x, y);
                            media += p.R;
                        }
                    }
                    int g = media / (Window * Window);
                    image.SetPixel(i,j, new RGB((Byte) g));
                }
            }
            return image;
        }
    }
}
