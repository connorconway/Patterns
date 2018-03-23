using System.Drawing;
using FlyweightPattern.Library;

namespace FlyweightPattern.Model
{
	public class StoneTile : ITile
	{
		private static int _objectCounter = 0;
		private readonly Brush _paintBrush;
		private readonly float _x;
		private readonly float _y;
		private readonly float _width;
		private readonly float _height;

		public StoneTile(float x, float y, float width, float height)
		{
			_paintBrush = Brushes.Green;
			_x = x;
			_y = y;
			_width = width;
			_height = height;

			++_objectCounter;
		}

		public void Draw(IGraphics g)
		{
			g.FillRectangle(_paintBrush, _x, _y, _width, _height);
		}
	}
}