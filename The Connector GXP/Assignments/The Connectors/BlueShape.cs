using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class BlueShape : Canvas
    {
        private int _shapeID = 0;
        private const int _connectorType = 1;
        private int _connectionsAvailable = 1;

        public BlueShape(int shapeID, int connectionsFree) : base(@"Assets\Shapes\BlueShape.png")
        {
            _shapeID = shapeID;
            _connectionsAvailable = connectionsFree;

            this.SetOrigin(this.width / 2, this.height / 2);
        }
    }
}
