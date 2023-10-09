using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var foodQuantity = int.Parse(Console.ReadLine());
        var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var queue = new Queue<int>(orders);

        Console.WriteLine(queue.Max());

        var iteration = queue.Count;

        for (int i = 0; i < iteration; i++)
        {
            if (queue.Peek() <= foodQuantity)
            {
                foodQuantity -= queue.Dequeue();
            }
        }
        if (queue.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}