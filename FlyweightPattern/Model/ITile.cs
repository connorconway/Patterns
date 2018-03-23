using FlyweightPattern.Library;

namespace FlyweightPattern.Model
{
	public interface ITile
	{
		void Draw(IGraphics g, float x, float y, float width, float height);
	}
}