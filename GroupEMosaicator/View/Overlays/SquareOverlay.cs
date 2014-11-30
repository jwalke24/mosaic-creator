using System.Drawing;

namespace GroupEMosaicator.View.Overlays
{


    /// <summary>
    /// Square Grid overlay class
    /// </summary>
    public class SquareOverlay : ShapeOverlay
    {

        /// <summary>
        /// Creates the square grid.
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

            return image;
        }
    }
}