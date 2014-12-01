using System;
using System.Collections.Generic;
using System.Drawing;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {
        /// <summary>
        ///     Creates the square block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public Image CreateSquareBlockMosaic(int blockSize, Bitmap image)
        {
            if (blockSize <= 0)
            {
                return null;
            }

            var newBitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(newBitmap);

            for (int column = 0; column < image.Height; column += blockSize)
            {
                for (int row = 0; row < image.Width; row += blockSize)
                {
                    var averagingArea = new Rectangle(row, column, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColor(averagingArea, image);
                    var averageBrush = new SolidBrush(averageColor);
                    graphics.FillRectangle(averageBrush, row, column, blockSize, blockSize);
                }
            }
            return newBitmap;
        }

        /// <summary>
        ///     Creates the triangle block mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public Image CreateTriangleBlockMosaic(int blockSize, Bitmap image)
        {
            if (blockSize <= 0)
            {
                return null;
            }

            var newBitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(newBitmap);

            for (int column = 0; column < image.Height; column += blockSize)
            {
                for (int row = 0; row < image.Width; row += blockSize)
                {
                    var averagingArea = new Rectangle(row, column, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColor(averagingArea, image);
                    var averageBrush = new SolidBrush(averageColor);
                    graphics.FillRectangle(averageBrush, row, column, blockSize, blockSize);
                }
            }
            return newBitmap;
        }

        /// <summary>
        ///     Creates the picture mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="bitmap">The image.</param>
        /// <param name="palette">The palette.</param>
        /// <param name="paletteColors">The average colors of images in the palette.</param>
        /// <returns></returns>
        public Image CreatePictureMosaic(int blockSize, Bitmap bitmap, List<Image> palette, List<Color> paletteColors)
        {
            var g = Graphics.FromImage(bitmap);

            for (int y = 0; y < bitmap.Height; y += blockSize)
            {
                for (int x = 0; x < bitmap.Width; x += blockSize)
                {
                    var dstRect = new Rectangle(x, y, blockSize, blockSize);
                    var averageColor = PixelFactory.GetAverageColor(dstRect, bitmap);
                    var bestMatchImage = (Bitmap)this.getBestMatchPaletteImage(averageColor, paletteColors, palette);
                    var srcRect = new Rectangle(0, 0, bestMatchImage.Width, bestMatchImage.Height);
                    g.DrawImage(bestMatchImage, dstRect, srcRect, GraphicsUnit.Pixel);
                }
            }
            g.Dispose();

            return bitmap;
        }

        private Image getBestMatchPaletteImage(Color averageColor, List<Color> paletteColors, List<Image> palette)
        {
            var smallestDifference = Double.MaxValue;
            var bestMatchIndex = 0;

            foreach (var currentColor in paletteColors)
            {
                var colorDifference = this.calculateColorDifference(averageColor, currentColor);

                if (colorDifference < smallestDifference)
                {
                    smallestDifference = colorDifference;
                    bestMatchIndex = paletteColors.IndexOf(currentColor);
                }
            }

            return palette[bestMatchIndex];
        }

        private double calculateColorDifference(Color averageColor, Color paletteColor)
        {
            long redMean = (averageColor.R + paletteColor.R) / 2;
            long redDifference = averageColor.R - paletteColor.R;
            long greenDifference = averageColor.G - paletteColor.G;
            long blueDifference = averageColor.B - paletteColor.B;
            return Math.Sqrt((((512 + redMean) * redDifference * redDifference) >> 8) + 4 * greenDifference * greenDifference + (((767 - redMean) * blueDifference * blueDifference) >> 8));
        }
    }
}