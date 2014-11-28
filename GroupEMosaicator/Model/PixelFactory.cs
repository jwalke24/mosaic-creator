using System;
using System.Drawing;

namespace GroupEMosaicator.Model
{
    public static class PixelFactory
    {
        public static Color GetAverageColor(Rectangle area, Bitmap bitmap)
        {
            if (bitmap == null)
            {
                throw new ArgumentNullException("the bitmap cannot be null");
            }
            if (area == null)
            {
                throw new ArgumentNullException("area cannot be null");
            }


            int redSum = 0;
            int greenSum = 0;
            int blueSum = 0;


            for (int y = area.Y; y < area.Height; y++)
            {
                for (int x = area.X; x < area.Width; x++)
                {
                    Color color = bitmap.GetPixel(area.X + x, area.Y + y);
                    int colorCode = color.ToArgb();
                    redSum += color.R;
                    greenSum += color.G;
                    blueSum += color.B;
                }
            }
            int redValue = (redSum/(area.Width*area.Height));
            int greenValue = (greenSum/(area.Width*area.Height));
            int blueValue = (blueSum/(area.Width*area.Height));

            return Color.FromArgb(255, redValue, greenValue, blueValue);
        }
    }
}