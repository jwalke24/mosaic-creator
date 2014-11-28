using System.Drawing;

namespace GroupEMosaicator.View
{
    public class SquareOverlay : ShapeOverlay
    {
        public SquareOverlay() : base()
        {
            
        }

        public override Image CreateGrid(Image image, int blocks)
        {
            int numOfCells = image.Width / blocks + 1;
            Graphics graphics = Graphics.FromImage(image);
            var pen = new Pen(Color.White);

            for (int y = 0; y < numOfCells; ++y)
            {
                graphics.DrawLine(pen, 0, y * blocks, numOfCells * blocks, y * blocks);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                graphics.DrawLine(pen, x * blocks, 0, x * blocks, numOfCells * blocks);
            }

            return image;
        }
    }
}