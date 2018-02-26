using System.Collections.Generic;
using System.Windows.Input;
using MementoPattern.Memento;

namespace MementoPattern
{
	public partial class MainWindow
	{
		private readonly Stack<IMemento> _undoStates = new Stack<IMemento>();
		private readonly Stack<IMemento> _redoStates = new Stack<IMemento>();

		public MainWindow()
		{
			InitializeComponent();
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Redo, OnExecutedCommands));
			UndoableInkCanvasTest.MouseUp += UndoableInkCanvasTest_MouseUp;
			StoreState();
		}

		private void UndoableInkCanvasTest_MouseUp(object sender, MouseButtonEventArgs e)
		{
			StoreState();
		}

		private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
		{
			var window = (MainWindow)sender;
			if (e.Command == ApplicationCommands.Undo)
				window.Undo(sender, e);
			if (e.Command == ApplicationCommands.Redo)
				window.Redo(sender, e);
		}

		private void Redo(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
		{
			if (_redoStates.Count > 1)
			{
				_undoStates.Push(_redoStates.Pop());
				var lastState = _redoStates.Peek();
				UndoableInkCanvasTest.SetMemento(lastState);
			}

			MementoUndoLabel.Content = _undoStates.Count;
			MementoRedoLabel.Content = _redoStates.Count;
		}

		private void Undo(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
		{
			if (_undoStates.Count > 1)
			{
				_redoStates.Push(_undoStates.Pop());
				var lastState = _undoStates.Peek();
				UndoableInkCanvasTest.SetMemento(lastState);
			}
			MementoUndoLabel.Content = _undoStates.Count;
			MementoRedoLabel.Content = _redoStates.Count;
		}

		private void StoreState()
		{
			var memento = UndoableInkCanvasTest.CreateMemento();
			_undoStates.Push(memento);
			MementoUndoLabel.Content = _undoStates.Count;
		}
	}
}