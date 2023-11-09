using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToArray();
        var number = int.Parse(Console.ReadLine());
        var queue = new Queue<string>(input);

        while (queue.Count > 1)
        {
            for (int i = 0; i < number; i++)
            {
                if (i == number - 1)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                else
                {
                    string temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }
            }
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}