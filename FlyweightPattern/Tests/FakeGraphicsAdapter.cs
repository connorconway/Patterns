using System;
using System.Drawing;
using FlyweightPattern.Library;

namespace FlyweightPattern.Tests
{
	public class FakeGraphicsAdapter : IGraphics
	{
		public void FillRectangle(Brush brush, float x, float y, float width, float height)
		{
			Console.WriteLine("Drawing shape!");
		}
	}
}