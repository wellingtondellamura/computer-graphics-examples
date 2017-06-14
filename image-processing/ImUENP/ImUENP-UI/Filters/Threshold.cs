using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class Threshold
    {
        public static Byte DEFAULT_VALUE = 127;
        
        public Byte Value { get; set; }

        public Threshold() : this(DEFAULT_VALUE)
        {

        }

        public Threshold(Byte value)
        {
            Value = value;
        }

        public RGBImage Process(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();//grayscale
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    if (p.R <= Value)
                    {
                        image.SetPixel(i, j, new RGB(0,0,0));
                    }
                    else
                    {
                        image.SetPixel(i, j, new RGB(255, 255, 255));
                    }
                    
                }
            }

            image.Type = ColorType.Binary;
            return image;
        }
    }
}
