using System.Drawing;

namespace GroupEMosaicator.View.Overlays
{


    /// <summary>
    /// Triangle grid overlay class
    /// </summary>
    internal class TriangleOverlay : ShapeOverlay
    {


        /// <summary>
        /// Creates the trianglular grid.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="blockSize">Size of the block.</param>
        /// <returns></returns>
        public override Image CreateGrid(Image image, int blockSize)
        {
            int numOfCells = image.Width / blockSize + 1;
            Graphics graphics = Graphics.FromImage(image);
            var pen = new Pen(Color.White);

            for (int y = 0; y < numOfCells; y++)
            {
                graphics.DrawLine(pen, 0, y * blockSize, numOfCells * blockSize, y * blockSize);
                graphics.DrawLine(pen, y * blockSize, 0, y * blockSize, numOfCells * blockSize);
            }

            for (int y = 0; y < image.Width; y++)
            {
                graphics.DrawLine(pen, 0, y * blockSize, y * blockSize, 0);
            }

            return image;
        }
    }
}