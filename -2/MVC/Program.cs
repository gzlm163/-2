using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductView view = new ProductView();
        ProductController controller = new ProductController(view);

        controller.Run();

        Console.ReadKey();
    }
}