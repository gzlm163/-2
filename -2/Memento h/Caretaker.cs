using System.Collections.Generic;

public class Caretaker {
  private Stack<Memento> _history = new Stack<Memento>();

  public void SaveState(FullNameClass originator) {
    _history.Push(originator.GetMemento());
  }

  public void RestoreState(FullNameClass originator) {
    if (_history.Count > 0) {
      originator.SetMemento(_history.Pop());
    }
  }
}