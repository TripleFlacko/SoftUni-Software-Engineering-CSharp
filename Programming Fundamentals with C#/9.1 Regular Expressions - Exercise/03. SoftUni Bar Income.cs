using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<Order> allOrders = new List<Order>();
        string regex = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.\d+|\d+)\$";

        string input;
        while ((input = Console.ReadLine()) != "end of shift")
        {
            foreach (Match match in Regex.Matches(input, regex))
            {
                Order order = new Order(match.Groups["customer"].Value,
                    match.Groups["product"].Value,
                    uint.Parse(match.Groups["count"].Value),
                    decimal.Parse(match.Groups["price"].Value));

                allOrders.Add(order);
            }
        }

        decimal totalIncome = 0;
        foreach (var order in allOrders)
        {
            Console.WriteLine($"{order.Customer}: {order.Product} - {order.Count * order.Price:f2}");
            totalIncome += order.Count * order.Price;
        }
        Console.WriteLine($"Total income: {totalIncome:f2}");
    }
}
class Order
{
    public Order(string customer, string product, uint count, decimal price)
    {
        Customer = customer;
        Product = product;
        Count = count;
        Price = price;
    }
    public string Customer { get; set; }
    public string Product { get; set; }
    public uint Count { get; set; }
    public decimal Price { get; set; }
}