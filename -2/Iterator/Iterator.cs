public class Iterator : IIterator {
  private readonly IterCollection _collection;
  private int _currentIndex;

  public Iterator(IterCollection collection) {
    _collection = collection;
    _currentIndex = 0;
  }

  public object First() {
    return _collection.GetItem(0);
  }

  public object Current() {
    return _collection.GetItem(_currentIndex);
  }

  public bool Finished() {
    return _currentIndex >= _collection.GetCount();
  }

  public object Next() {
    return _collection.GetItem(_currentIndex++);
  }
}