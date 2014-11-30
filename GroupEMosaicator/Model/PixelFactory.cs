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

            if (area.X + area.Width >= bitmap.Width)
            {
                area.Width = bitmap.Width - area.X - 1;
            }

            if (area.Y + area.Height >= bitmap.Height)
            {
                area.Height = bitmap.Height - area.Y - 1;
            }

            int redSum = 0;
            int greenSum = 0;
            int blueSum = 0;
            Color color = Color.Empty;

            for (int i = 0; i < area.Width; i++)
            {
                for (int j = 0; j < area.Height; j++)
                {
                    color = bitmap.GetPixel(area.X + i, area.Y + j);
                    redSum += color.R;
                    greenSum += color.G;
                    blueSum += color.B;
                }
            }

            Color newColor = getNewColor(area, redSum, greenSum, blueSum);

            return newColor;
        }

        private static Color getNewColor(Rectangle area, int redSum, int greenSum, int blueSum)
        {
            int redValue = (redSum/(area.Width*area.Height + 1));
            int greenValue = (greenSum/(area.Width*area.Height + 1));
            int blueValue = (blueSum/(area.Width*area.Height + 1));

            Color newColor = Color.FromArgb(255, redValue, greenValue, blueValue);
            return newColor;
        }
    }
}