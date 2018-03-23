using System.Drawing;

namespace FlyweightPattern.Library
{
	public interface IGraphics
	{
		void FillRectangle(Brush brush, float x, float y, float width, float height);
	}
}