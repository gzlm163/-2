public class FactoryOne : AbstractFactory
{
    public override ProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override ProductB CreateProductB()
    {
        return new ProductB1();
    }
}