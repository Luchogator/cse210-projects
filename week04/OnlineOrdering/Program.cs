using System;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1200, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");    
    }
}
