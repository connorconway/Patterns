using System.Drawing;
using FlyweightPattern.Library;

namespace FlyweightPattern.Model
{
	public class CeramicTile : ITile
	{
		private static int _objectCounter = 0;
		private readonly Brush _paintBrush;

		public CeramicTile()
		{
			_paintBrush = Brushes.Red;
			++_objectCounter;
		}

		public void Draw(IGraphics g, float x, float y, float width, float height)
		{
			g.FillRectangle(_paintBrush, x, y, width, height);
		}
	}
}