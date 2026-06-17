using System;

public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    public void Method1()
    {
        Console.WriteLine("Singleton.Method1");
    }

    public void Method2()
    {
        Console.WriteLine("Singleton.Method2");
    }
}
