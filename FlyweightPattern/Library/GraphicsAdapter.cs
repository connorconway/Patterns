using System.Drawing;

namespace FlyweightPattern.Library
{
	public class GraphicsAdapter : IGraphics
	{
		private readonly Graphics _graphics;

		public GraphicsAdapter(Graphics graphics, Brush brush)
		{
			_graphics = graphics;
		}

		public void FillRectangle(Brush brush, float x, float y, float width, float height)
		{
			_graphics.FillRectangle(brush, x, y, width, height);
		}
	}
}