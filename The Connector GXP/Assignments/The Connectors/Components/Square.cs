using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GXPEngine
{
    public class Square : Canvas
    {
        public Vec2 position;
        public Vec2 velocity;
        public readonly int radius;
        private Color _squareColor;

        public Square(int pRadius, Vec2 pPosition = null, Vec2 pVelocity = null, Color? pColor = null) : base (pRadius*2, pRadius*2)
        {
            radius = pRadius;
            SetOrigin(radius, radius);

            position = pPosition ?? Vec2.zero;
            velocity = pVelocity ?? Vec2.zero;
            _squareColor = pColor ?? Color.Red;

            draw();
            Step();
        }

        private void draw()
        {
            graphics.Clear(Color.Empty);
            graphics.FillRectangle(
                new SolidBrush(_squareColor),
                0, 0, 2 * radius, 2 * radius
            );
        }

        public void Step(bool skipVelocity = false)
        {
            if (position == null || velocity == null)
                return;

            if (!skipVelocity) position.Add(velocity);

            x = position.x;
            y = position.y;
        }

        public Color SquareColor
        {
            get
            {
                return _squareColor;
            }

            set
            {
                _squareColor = value;
                draw();
            }
        }
    }
}
