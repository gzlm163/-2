public class Iterator : IIterator {
  private IterCollection _collection;
  private int _currentIndex;

  public Iterator(IterCollection collection) {
    _collection = collection;
    _currentIndex = 0;
  }

  public object First() {
    if (_collection.GetCount() > 0) {
      return _collection.GetItem(0);
    }
    return null;
  }

  public object Current() {
    if (_currentIndex >= 0 && _currentIndex < _collection.GetCount()) {
      return _collection.GetItem(_currentIndex);
    }
    return null;
  }

  public bool Finished() {
    return _currentIndex >= _collection.GetCount();
  }

  public object Next() {
    if (!Finished()) {
      object item = _collection.GetItem(_currentIndex);
      ++_currentIndex;
      return item;
    }
    return null;
  }
}