using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.filters
{
    public class Gray
    {
        
        public Gray()
        {
        }

        public Bitmap process (Bitmap bmp)
        {
            Bitmap newImage = (Bitmap)bmp.Clone();
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color c = newImage.GetPixel(i, j);
                    int g = (c.R + c.G + c.B) / 3;
                    Color gray = Color.FromArgb(g, g, g);
                    newImage.SetPixel(i, j, gray);
                }
            }
            return newImage;
        }
    }
}
