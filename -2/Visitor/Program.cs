using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IElement> elements = new List<IElement>
        {
            new SomeClass1(1),
            new SomeClass2(2),
            new SomeClass3(3)
        };

        IVisitor visitor = new PrintVisitor();

        foreach (IElement element in elements)
        {
            element.Accept(visitor);
        }
    }
}