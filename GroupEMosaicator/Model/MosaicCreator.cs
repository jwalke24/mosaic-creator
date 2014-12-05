using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupEMosaicator.Model
{
    internal class MosaicCreator
    {
        private Image previousImage;

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
                    Color averageColor = PixelFactory.GetAverageColorOfSquareBlock(averagingArea, image);
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
        public Image CreateLowerLeftToUpperRightTriangleBlockMosaic(int blockSize, Bitmap image)
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

                    Color averageTopColor = PixelFactory.GetAverageColorOfTopLeftTriangle(averagingArea, image);
                    var averageTopBrush = new SolidBrush(averageTopColor);
                    Point[] topPoints = this.getTopLeftTrianglePoints(blockSize, row, column);
                    graphics.FillPolygon(averageTopBrush, topPoints);

                    Color averageBottomColor = PixelFactory.GetAverageColorOfBottomRightTriangle(averagingArea, image);
                    var averageBottomBrush = new SolidBrush(averageBottomColor);
                    Point[] botPoints = this.getBottomRightTriangePoints(blockSize, row, column);
                    graphics.FillPolygon(averageBottomBrush, botPoints);
                }
            }
            return newBitmap;
        }

        public Image CreateUpperRightToLowerLeftTriangleBlockMosaic(int blockSize, Bitmap image)
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

                    Color averageTopColor = PixelFactory.GetAverageColorOfTopRightTriangle(averagingArea, image);
                    var averageTopBrush = new SolidBrush(averageTopColor);
                    Point[] topPoints = this.getTopRightTrianglePoints(blockSize, row, column);
                    graphics.FillPolygon(averageTopBrush, topPoints);

                    Color averageBottomColor = PixelFactory.GetAverageColorOfBottomLeftTriangle(averagingArea, image);
                    var averageBottomBrush = new SolidBrush(averageBottomColor);
                    Point[] botPoints = this.getBottomLeftTrianglePoints(blockSize, row, column);
                    graphics.FillPolygon(averageBottomBrush, botPoints);
                }
            }
            return newBitmap;
        }

        private Point[] getTopLeftTrianglePoints(int blockSize, int row, int column)
        {
            var topPoints = new Point[3];
            topPoints[0].X = row;
            topPoints[0].Y = column;
            topPoints[1].X = row + blockSize;
            topPoints[1].Y = column;
            topPoints[2].X = row;
            topPoints[2].Y = column + blockSize;
            return topPoints;
        }

        private Point[] getBottomRightTriangePoints(int blockSize, int row, int column)
        {
            var botPoints = new Point[3];
            botPoints[0].X = row + blockSize;
            botPoints[0].Y = column + blockSize;
            botPoints[1].X = row + blockSize;
            botPoints[1].Y = column;
            botPoints[2].X = row;
            botPoints[2].Y = column + blockSize;
            return botPoints;
        }

        private Point[] getTopRightTrianglePoints(int blockSize, int row, int column)
        {
            var topPoints = new Point[3];
            topPoints[0].X = row;
            topPoints[0].Y = column;
            topPoints[1].X = row + blockSize;
            topPoints[1].Y = column;
            topPoints[2].X = row + blockSize;
            topPoints[2].Y = column + blockSize;
            return topPoints;
        }

        private Point[] getBottomLeftTrianglePoints(int blockSize, int row, int column)
        {
            var topPoints = new Point[3];
            topPoints[0].X = row;
            topPoints[0].Y = column;
            topPoints[1].X = row;
            topPoints[1].Y = column + blockSize;
            topPoints[2].X = row + blockSize;
            topPoints[2].Y = column + blockSize;
            return topPoints;
        }

        /// <summary>
        ///     Creates the picture mosaic.
        /// </summary>
        /// <param name="blockSize">Size of the block.</param>
        /// <param name="bitmap">The image.</param>
        /// <param name="palette">The palette.</param>
        /// <returns></returns>
        public Image CreatePictureMosaic(int blockSize, Bitmap bitmap, ImageList.ImageCollection palette)
        {
            Graphics g = Graphics.FromImage(bitmap);

            List<Image> images = this.copyPalette(palette);
            List<Color> colors = this.averagePaletteColors(images);

            for (int y = 0; y < bitmap.Height; y += blockSize)
            {
                for (int x = 0; x < bitmap.Width; x += blockSize)
                {
                    var dstRect = new Rectangle(x, y, blockSize, blockSize);
                    Color averageColor = PixelFactory.GetAverageColorOfSquareBlock(dstRect, bitmap);

                    List<Image> closeMatches = this.getBestMatchPaletteImage(averageColor, images, colors);
                    Image randomMatch = this.getRandomBestMatch(closeMatches);
                    this.previousImage = randomMatch;

                    var srcRect = new Rectangle(0, 0, randomMatch.Width, randomMatch.Height);
                    g.DrawImage(randomMatch, dstRect, srcRect, GraphicsUnit.Pixel);
                }
            }
            g.Dispose();

            return bitmap;
        }

        private Image getRandomBestMatch(List<Image> closeMatches)
        {
            var randomizer = new Random();

            int index;

            do
            {
                index = randomizer.Next(closeMatches.Count);
            } while (closeMatches[index].Equals(this.previousImage));

            return closeMatches[index];
        }

        private List<Image> copyPalette(ImageList.ImageCollection palette)
        {
            var images = new List<Image>(palette.Count);
            for (int i = 0; i < palette.Count; i++)
            {
                images.Add(palette[i]);
            }
            return images;
        }

        private List<Color> averagePaletteColors(IEnumerable<Image> images)
        {
            var averageColors = new List<Color>();

            foreach (Image image in images)
            {
                var srcRect = new Rectangle(0, 0, image.Width, image.Height);
                Color currentAverage = PixelFactory.GetAverageColorOfSquareBlock(srcRect, (Bitmap) image);
                averageColors.Add(currentAverage);
            }

            return averageColors;
        }

        private List<Image> getBestMatchPaletteImage(Color averageColor, IEnumerable<Image> images,
            IEnumerable<Color> colors)
        {
            const int maxNumberOfCloseMatches = 5;

            var imagesCopy = new List<Image>(images);
            var colorsCopy = new List<Color>(colors);

            var closeMatches = new List<Image>(maxNumberOfCloseMatches);

            while (closeMatches.Count < maxNumberOfCloseMatches && imagesCopy.Count > 0)
            {
                double smallestDifference = Double.MaxValue;
                int bestMatchIndex = 0;

                foreach (Color currentColor in colorsCopy)
                {
                    double colorDifference = this.calculateColorDifference(averageColor, currentColor);

                    if (colorDifference < smallestDifference)
                    {
                        smallestDifference = colorDifference;
                        bestMatchIndex = colorsCopy.IndexOf(currentColor);
                    }
                }
                closeMatches.Add(imagesCopy[bestMatchIndex]);
                imagesCopy.RemoveAt(bestMatchIndex);
                colorsCopy.RemoveAt(bestMatchIndex);
            }
            return closeMatches;
        }

        private double calculateColorDifference(Color averageColor, Color paletteColor)
        {
            long redDifference = averageColor.R - paletteColor.R;
            long greenDifference = averageColor.G - paletteColor.G;
            long blueDifference = averageColor.B - paletteColor.B;
            return
                Math.Sqrt((redDifference*redDifference) + (greenDifference*greenDifference) +
                          (blueDifference*blueDifference));
        }
    }
}