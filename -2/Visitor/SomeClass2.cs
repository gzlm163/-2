public class SomeClass2 : IElement
{
    public int SomeProperty2 { get; set; }

    public SomeClass2(int value)
    {
        SomeProperty2 = value;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}