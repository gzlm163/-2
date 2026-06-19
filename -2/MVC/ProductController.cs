using System;

public class ProductController
{
    private Product _product;
    private ProductView _view;
    private bool _isRunning;

    public ProductController(ProductView view)
    {
        _view = view;
        _isRunning = true;
    }

    public void Run()
    {
        while (_isRunning)
        {
            _view.ShowMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    _view.ShowEmptyLine();
                    CreateNewProduct();
                    break;

                case "2":
                    _isRunning = false;
                    _view.ShowMessage("Exiting...");
                    break;

                default:
                    _view.ShowMessage("Invalid choice. Try again.");
                    break;
            }
        }
    }

    public void CreateNewProduct()
    {
        int id = _view.GetProductIdFromUser();
        string name = _view.GetProductNameFromUser();
        int price = _view.GetProductPriceFromUser();

        Console.WriteLine();

        _product = new Product(id, name, price);
        _view.DisplayProduct(_product);
    }
}
