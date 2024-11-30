using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating address for customers
        var address1 = new Address("1233", "Kenge/Manzonzo", "Muya/Mbuji-Mayi", "DRC");
        var address2 = new Address("456 Ramazani", "Kajiba-Muya", "Muya/Mbuji-Mayi", "DRC");

        // Creating customers
        var customer1 = new Customer("Ampikalgede Junior", address1);
        var customer2 = new Customer("Antoine Mpinga", address2);

        // Creating products
        var product1 = new Product("Laptop", 101, 999.99, 1);
        var product2 = new Product("Headphones", 102, 199.99, 2);

        // Creating orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
    }
}
