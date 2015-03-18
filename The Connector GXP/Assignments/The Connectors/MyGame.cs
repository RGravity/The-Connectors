using System;
using GXPEngine;
using System.Drawing;
using GXPEngine.OpenGL;

public class MyGame : Game
{
    private Level _level;

	public MyGame () : base(800, 600, false, true)
	{
        _level = new Level();
        AddChild(_level);
	}
		
	static void Main() {
		new MyGame().Start();
	}

	void Update () {
	}
}

