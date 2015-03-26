using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class YellowShape : Canvas
    {
        private int _shapeID = 0;
        private const int _connectorType = 3;
        private int _connectionsAvailable = 3;

        public YellowShape(int shapeID, int connectionsFree) : base(@"Assets\Shapes\YellowShape.png")
        {
            _shapeID = shapeID;
            _connectionsAvailable = connectionsFree;
        }
    }
}
