using System;

class Program {
  static void Main(string[] args) {
    IIterCollection collection = new IterCollection(10);
    IIterator iterator = collection.GetIterator();
    while (!iterator.Finished()) {
      Console.WriteLine(iterator.Next());
    }
    Console.ReadKey();
  }
}