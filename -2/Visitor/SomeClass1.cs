public class SomeClass1 : IElement
{
    public int SomeProperty1 { get; set; }

    public SomeClass1(int value)
    {
        SomeProperty1 = value;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}