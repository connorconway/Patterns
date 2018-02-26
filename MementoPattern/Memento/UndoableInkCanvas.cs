using System.Linq;
using System.Windows.Controls;
using System.Windows.Ink;

namespace MementoPattern.Memento
{
	public class UndoableInkCanvas : InkCanvas
	{
		public IMemento CreateMemento()
		{
			var copy = Strokes.ToArray();
			return new InkCanvasMemento {State = copy};
		}

		public void SetMemento(IMemento memento)
		{
			Strokes = new StrokeCollection((Stroke[])memento.State);
		}

		private class InkCanvasMemento : IMemento
		{
			public object State { get; set; }
		}
	}
}