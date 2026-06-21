using System;

internal class Program {
  private static void Main(string[] args) {
    AbstractFactory[] factories = { new FactoryOne(), new FactoryTwo() };

    foreach (AbstractFactory factory in factories) {
      ProductA productA = factory.CreateProductA();
      ProductB productB = factory.CreateProductB();

      Console.WriteLine(productA.GetName());
      Console.WriteLine(productB.GetName());
      Console.WriteLine();
    }

    Console.ReadKey();
  }
}