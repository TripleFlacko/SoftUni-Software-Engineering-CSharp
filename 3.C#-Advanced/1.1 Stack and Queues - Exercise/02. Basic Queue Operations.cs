class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int toPush = input[0];
        int toPop = input[1];
        int toCheck = input[2];

        var queue = new Queue<int>();

        var num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < toPush; i++)
        {
            queue.Enqueue(num[i]);
        }

        for (int i = 0; i < toPop; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count > 0)
        {
            Console.WriteLine(queue.Contains(toCheck) ? "true" : queue.Min());
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}