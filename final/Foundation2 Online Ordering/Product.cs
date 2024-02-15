using System;

class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }

    }

    public string ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public decimal CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {_name} ({_productId})");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
    }
}