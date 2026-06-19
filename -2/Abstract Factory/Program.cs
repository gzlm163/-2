using System;

internal class Program {
  private static void UseAbstractFactory(AbstractFactory factory) {
    ProductA productA = factory.CreateProductA();
    ProductB productB = factory.CreateProductB();

    Console.WriteLine(productA.GetName());
    Console.WriteLine(productB.GetName());
    Console.WriteLine();
  }

  private static void Main(string[] args) {
    AbstractFactory factoryOne = new FactoryOne();
    AbstractFactory factoryTwo = new FactoryTwo();

    UseAbstractFactory(factoryOne);
    UseAbstractFactory(factoryTwo);

    Console.ReadKey();
  }
}