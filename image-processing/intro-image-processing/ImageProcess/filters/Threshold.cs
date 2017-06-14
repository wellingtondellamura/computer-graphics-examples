using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.filters
{
    public class Threshold
    {
        public short Value { get; set; }

        public Threshold(short value)
        {
            this.Value = value;
        }

        public Threshold() : this(127) { }

        public Bitmap process(Bitmap bmp)
        {
            Bitmap newImage = (Bitmap)bmp.Clone();
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    var px = bmp.GetPixel(i, j).R;
                    if (px >= Value)
                    {
                        newImage.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                }
            }
            return newImage;
        }
    }
}
