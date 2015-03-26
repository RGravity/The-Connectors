using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class GreenShape : Canvas
    {
        private int _shapeID = 0;
        private const int _connectorType = 2;
        private int _connectionsAvailable = 2;

        public GreenShape(int shapeID, int connectionsFree) : base(@"Assets\Shapes\GreenShape.png")
        {
            _shapeID = shapeID;
            _connectionsAvailable = connectionsFree;
        }
    }
}
