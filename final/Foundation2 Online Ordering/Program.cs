using System;

class Program
{
    static void Main(string[] args)
    {

        //Address

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "USA");
        Address address3 = new Address("789 Pine Rd", "Othertown", "TX", "USA");

        // Customer

        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);
        Customer customer3 = new Customer("Charlie", address3);

        //Products

        Product product1 = new Product("Chair", "CH1", 50.0m, 2);
        Product product2 = new Product("Table", "TB1", 100.0m, 1);
        Product product3 = new Product("Lamp", "LP1", 25.0m, 3);

        //Orders

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);

        //Display

        order1.DisplayOrderInfo();
        Console.WriteLine();

        order2.DisplayOrderInfo();
        Console.WriteLine();

        order3.DisplayOrderInfo();
        Console.WriteLine();
    }
}