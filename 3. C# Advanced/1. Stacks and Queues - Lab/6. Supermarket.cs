internal class Program
{
    static void Main(string[] args)
    {
        var queue = new Queue<string>();
        while (true)
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "Paid":
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Peek());
                        queue.Dequeue();
                    }
                    break;
                case "End":
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                default:
                    queue.Enqueue(input);
                    break;
            }
        }
    }
}