public class FactoryTwo : AbstractFactory {
  public override ProductA CreateProductA() {
    return new ProductA2();
  }

  public override ProductB CreateProductB() {
    return new ProductB2();
  }
}