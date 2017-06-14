using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImUENP.UI.Filters
{
    public class MultiThreshold
    {
        
        public List<ThresholdPoint> Points { get; set; }

        public MultiThreshold(params ThresholdPoint[] points)
        {            
            Points = points.ToList();
        }
                
        public RGBImage Process(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();//grayscale
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    var gray = pixel.R;
                    Points.ForEach(p =>
                    {
                        if (gray >= p.Min && gray < p.Max)
                        {
                            image.SetPixel(i, j, p.Color);
                        }
                    });                    
                }
            }
            return image;
        }
    }

    public struct ThresholdPoint
    {
        public byte Min { get; set; }
        public byte Max { get; set; }
        public RGB Color { get; set; }

        public ThresholdPoint(byte min, byte max, RGB color)
        {
            Min = min;
            Max = max;
            Color = color;
        }
    }

}
