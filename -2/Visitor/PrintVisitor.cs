using System;

public class PrintVisitor : IVisitor
{
    public void Visit(SomeClass1 element)
    {
        Console.WriteLine(element.SomeProperty1);
    }

    public void Visit(SomeClass2 element)
    {
        Console.WriteLine(element.SomeProperty2);
    }

    public void Visit(SomeClass3 element)
    {
        Console.WriteLine(element.SomeProperty3);
    }
}