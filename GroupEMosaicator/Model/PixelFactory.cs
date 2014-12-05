using System.Drawing;

namespace GroupEMosaicator.Model
{
    public static class PixelFactory
    {
        /// <summary>
        ///     Gets the average color of square block.
        /// </summary>
        /// <param name="area">The area.</param>
        /// <param name="bitmap">The bitmap.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        ///     @the bitmap cannot be null
        ///     or
        ///     @area cannot be null
        /// </exception>
        public static Color GetAverageColorOfSquareBlock(Rectangle area, Bitmap bitmap)
        {
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

            for (int i = 0; i < area.Width; i++)
            {
                for (int j = 0; j < area.Height; j++)
                {
                    Color color = bitmap.GetPixel(area.X + i, area.Y + j);
                    redSum += color.R;
                    greenSum += color.G;
                    blueSum += color.B;
                }
            }

            Color newColor = getNewRectangleColor(area, redSum, greenSum, blueSum);

            return newColor;
        }

        /// <summary>
        ///     Gets the average color of top triangle.
        /// </summary>
        /// <param name="area">The area.</param>
        /// <param name="bitmap">The bitmap.</param>
        /// <returns></returns>
        public static Color GetAverageColorOfTopTriangle(Rectangle area, Bitmap bitmap)
        {
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
            int num = 0;
            for (int j = 0; j < area.Height; j++)
            {
                num++;
                for (int i = 0; i < area.Width - num; i++)
                {
                    Color color = bitmap.GetPixel(area.X + i, area.Y + j);
                    redSum += color.R;
                    greenSum += color.G;
                    blueSum += color.B;
                }
            }

            Color newColor = getNewTriangleColor(area, redSum, greenSum, blueSum);

            return newColor;
        }

        /// <summary>
        ///     Gets the average color of bottom triangle.
        /// </summary>
        /// <param name="area">The area.</param>
        /// <param name="bitmap">The bitmap.</param>
        /// <returns></returns>
        public static Color GetAverageColorOfBottomTriangle(Rectangle area, Bitmap bitmap)
        {
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

            for (int j = area.Height; j > 0; j--)
            {
                for (int i = area.Width; i > 0 + j; i--)
                {
                    Color color = bitmap.GetPixel(area.X + i, area.Y + j);
                    redSum += color.R;
                    greenSum += color.G;
                    blueSum += color.B;
                }
            }

            Color newColor = getNewTriangleColor(area, redSum, greenSum, blueSum);
            return newColor;
        }

        private static Color getNewTriangleColor(Rectangle area, int redSum, int greenSum, int blueSum)
        {
            int redValue = 2*(redSum*checkBoxSize(area)/(area.Width*area.Height));
            int greenValue = 2*(greenSum*checkBoxSize(area)/(area.Width*area.Height));
            int blueValue = 2*(blueSum*checkBoxSize(area)/(area.Width*area.Height));

            Color newColor = Color.FromArgb(255, redValue, greenValue, blueValue);
            return newColor;
        }

        private static int checkBoxSize(Rectangle area)
        {
            return 1;
        }

        private static Color getNewRectangleColor(Rectangle area, int redSum, int greenSum, int blueSum)
        {
            int redValue = (redSum/(area.Width*area.Height));
            int greenValue = (greenSum/(area.Width*area.Height));
            int blueValue = (blueSum/(area.Width*area.Height));

            Color newColor = Color.FromArgb(255, redValue, greenValue, blueValue);
            return newColor;
        }
    }
}