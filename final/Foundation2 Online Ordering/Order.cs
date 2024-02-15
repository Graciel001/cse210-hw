using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.Price * product.Quantity;
        }
        if (_customer.Address.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Customer: {_customer.Name}\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} ({product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {_customer.Name}\n";
        shippingLabel += $"Address: {_customer.Address.GetFullAddress()}\n";
        return shippingLabel;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine("Order Information:");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(GetShippingLabel());
    }
}