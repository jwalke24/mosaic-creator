using System.Drawing;

namespace GroupEMosaicator.View
{
    public abstract class ShapeOverlay
    {
        public ShapeOverlay()
        {
            
        }

        public abstract Image CreateGrid(Image image, int blocks);

    }
}