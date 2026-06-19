using System.Collections;

public class IterCollection : IIterCollection {
  private ArrayList _items = new ArrayList();

  public IterCollection() {
  }

  public IterCollection(int size) {
    for (int elementIndex = 0; elementIndex < size; ++elementIndex) {
      _items.Add(elementIndex + 1);
    }
  }

  public IIterator GetIterator() {
    return new Iterator(this);
  }

  public object GetItem(int index) {
    return _items[index];
  }

  public int GetCount() {
    return _items.Count;
  }
}