using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.AddProduct("Pencil", "324A", 2, 10);
        order1.AddProduct("Eraser", "524Z", 3, 5);
        order1.SetCustomer("Bob the Builder", "123 Elm St", "New York City", "NY", "USA");

        Order order2 = new Order();
        order2.AddProduct("Eraser", "524Z", 3, 5);
        order2.AddProduct("Pencil", "324A", 2, 10);
        order2.SetCustomer("Big Ben", "246 Oak Circle", "London", "England", "UK");

        Console.WriteLine($"Order1 Total Cost: ${order1.GetTotalCost()}");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine();

        Console.WriteLine($"Order2 Total Cost: ${order2.GetTotalCost()}");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine();

    }
}