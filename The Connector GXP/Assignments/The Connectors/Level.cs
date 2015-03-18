using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GXPEngine
{
    class Level:GameObject
    {
        private Canvas _canvas;

        public Level() : base()
        {
            _canvas = new Canvas(800, 600);
            _canvas.graphics.Clear(Color.White);
            AddChild(_canvas);
        }

        void Update()
        {

        }

    }
}
