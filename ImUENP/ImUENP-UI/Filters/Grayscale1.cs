using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class Grayscale1
    {
        public RGBImage Process(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    var g = p.R * 0.3 + p.G * 0.59 + p.B * 0.11;
                    Byte ig = (Byte)g;
                    image.SetPixel(i, j, new RGB(ig, ig, ig));
                }
            }
            image.Type = ColorType.Grayscale;
            return image;
        }
    }
}
