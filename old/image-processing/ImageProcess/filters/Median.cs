using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.filters
{
    public class Median
    {
        public Int32 Window { get; set; }

        public Median(Int32 window)
        {
            this.Window = window;
        }

        public Median() : this(3) { }

        public Bitmap process (Bitmap bmp)
        {
            var offset = Window / 2;
            Bitmap newImage = (Bitmap) bmp.Clone();
            for (int i = offset; i<newImage.Width- offset; i++)
            {
                for (int j = offset; j < newImage.Height- offset; j++)
                {
                    //window
                    List<short> px = new List<short>();
                    for (int x = i - offset; x <= i+offset; x++)
                    {
                        for (int y = j - offset; y <= j+offset; y++)
                        {
                            px.Add(bmp.GetPixel(x,y).R);
                        }
                    }                   
                    px.Sort();
                    int p = (Window * Window / 2) + 1;
                    int mean = px[p];
                    newImage.SetPixel(i, j, Color.FromArgb(mean, mean, mean));
                }
            }
            return newImage;
        }
    }
}
