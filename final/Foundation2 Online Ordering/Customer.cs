using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address{
        get { return _address; }
        set {_address = value; }
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {_name}");
        Console.WriteLine("Address:");
        Console.WriteLine(_address.GetFullAddress());
        Console.WriteLine($"Is in USA: {IsInUSA()}");
    }
}