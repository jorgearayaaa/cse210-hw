using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress = new Address("Alcalde Pedro Alarcon 887", "Santiago", "San Migúel", "Chile");
        Customer customer = new Customer("John Doe", customerAddress);

        Product product1 = new Product("Product 1", "P1", 10.0, 3);
        Product product2 = new Product("Product 2", "P2", 5.0, 2);

        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
    }
}
