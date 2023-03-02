using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Sitronics
{
    public class ImageReader
    {
        public static Coordinates GetCenterOfInput(Bitmap bitmap)
        {
            Color PixelColor;

            List<Coordinates> coords = new List<Coordinates>();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    PixelColor = bitmap.GetPixel(x, y);
                    if (PixelColor == Color.FromArgb(255, 255, 255, 255))
                    {
                        coords.Add(new Coordinates(x, y));
                    }
                }
            }
            if(coords.Count > 0) 
            {
                return coords[coords.Count / 2];
            }
            else
            {
                return null;
            }
        }
    }
}
