using System.Collections.Generic;
using System.Windows.Input;
using MementoPattern.Memento;

namespace MementoPattern
{
	public partial class MainWindow
	{
		private readonly Stack<IMemento> _states = new Stack<IMemento>();
		public MainWindow()
		{
			InitializeComponent();
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));
			UndoableInkCanvasTest.MouseUp += UndoableInkCanvasTest_MouseUp;
			StoreState();
		}

		private void UndoableInkCanvasTest_MouseUp(object sender, MouseButtonEventArgs e)
		{
			StoreState();
		}

		private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
		{
			var window = (MainWindow) sender;
			if (e.Command == ApplicationCommands.Undo)
			{
				window.Undo(sender, e);
			}
		}

		private void Undo(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
		{
			if (_states.Count > 1)
			{
				_states.Pop();
				var lastState = _states.Peek();
				UndoableInkCanvasTest.SetMemento(lastState);
			}
			MementoLabel.Content = _states.Count;
		}

		private void StoreState()
		{
			var memento = UndoableInkCanvasTest.CreateMemento();
			_states.Push(memento);
			MementoLabel.Content = _states.Count;
		}
	}
}