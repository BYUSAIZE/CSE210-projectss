using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 900, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P102", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 45, 1));

        // Second Order (International)
        Address address2 = new Address(
            "45 King Road",
            "Harare",
            "Harare",
            "Zimbabwe");

        Customer customer2 = new Customer("Prosper Saize", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P201", 600, 1));
        order2.AddProduct(new Product("Phone Case", "P202", 20, 3));
        order2.AddProduct(new Product("Charger", "P203", 30, 2));

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}