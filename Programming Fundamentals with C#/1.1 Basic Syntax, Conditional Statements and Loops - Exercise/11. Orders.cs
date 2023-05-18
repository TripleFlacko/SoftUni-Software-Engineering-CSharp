using System;

namespace _11.Orders
{
    class Program
    {
        static void Main()
        {
            var ordersCount = int.Parse(Console.ReadLine());
            var total = 0d;

            for (int i = 0; i < ordersCount; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsulesCount = int.Parse(Console.ReadLine());

                var totalPerOrder = days * capsulesCount * pricePerCapsule;
                total += totalPerOrder;

                Console.WriteLine($"The price for the coffee is: ${totalPerOrder:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}