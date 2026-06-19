public class SomeClass3 : IElement
{
    public int SomeProperty3 { get; set; }

    public SomeClass3(int value)
    {
        SomeProperty3 = value;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}