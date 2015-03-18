using System;

namespace GXPEngine
{
	public class Vec2
	{
		public static Vec2 zero { get { return new Vec2 (0, 0); } }

		public float x = 0;
		public float y = 0;

		public Vec2 (float pX = 0, float pY = 0)
		{
			x = pX;
			y = pY;
		}


		public Vec2 Scale (float scalar)
		{
			x *= scalar;
			y *= scalar;
			return this;
		}

		public Vec2 Normal ()
		{
			return new Vec2 (-y, x).Normalize ();
		}

		public Vec2 Add (Vec2 other)
		{
			x += other.x;
			y += other.y;
			return this;
		}

		public override string ToString ()
		{
			return String.Format ("({0}, {1})", x, y);
		}

		public Vec2 Sub (Vec2 other)
		{
			x -= other.x;
			y -= other.y;
			return this;
		}

		public Vec2 Clone ()
		{
			return new Vec2 (x, y);
		}

		public float Dot (Vec2 other)
		{
			return x * other.x + y * other.y;
		}


		public Vec2 Normalize ()
		{
			if (x == 0 && y == 0) {
				return this;
			} else {
				return Scale (1 / Length ());
			}
		}


		public float Length ()
		{
			return (float)Math.Sqrt (x * x + y * y);
		}

		public float GetAngleRadians () {
			return (float)Math.Atan2 (y, x);
		}

		public float GetAngleDegrees() {
			return (float)(GetAngleRadians () * 180 / Math.PI);
		}

	}
}

