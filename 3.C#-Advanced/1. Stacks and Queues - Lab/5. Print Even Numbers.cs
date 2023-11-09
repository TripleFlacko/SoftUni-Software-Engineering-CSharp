internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var queue = new Queue<int>(input);
        var finalQueue = new Queue<int>();
        while (queue.Count > 0)
        {
            var num = queue.Dequeue();
            if (num % 2 == 0)
            {
                finalQueue.Enqueue(num);
            }
        }
        Console.WriteLine(string.Join(", ", finalQueue));
    }
}