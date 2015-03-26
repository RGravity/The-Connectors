using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class PinkShape : Canvas
    {
        private int _shapeID = 0;
        private const int _connectorType = 4;
        private int _connectionsAvailable = 4;

        public PinkShape(int shapeID, int connectionsFree) : base(@"Assets\Shapes\PinkShape.png")
        {
            _shapeID = shapeID;
            _connectionsAvailable = connectionsFree;

            this.SetOrigin(this.width / 2, this.height / 2);
        }
    }
}
