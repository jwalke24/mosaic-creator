using System.Drawing;

namespace GroupEMosaicator.View.Overlays
{
    public abstract class ShapeOverlay
    {


        public abstract Image CreateGrid(Image image, int blockSize);

    }
}