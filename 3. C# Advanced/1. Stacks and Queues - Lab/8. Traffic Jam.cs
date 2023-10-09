class Program
{
    static void Main(string[] args)
    {
        var numberOfCars = int.Parse(Console.ReadLine());
        var queue = new Queue<string>();
        var counter = 0;

        while (true)
        {
            var command = Console.ReadLine();

            switch (command)
            {
                case "green":
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                    break;
                case "end":
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    return;
                default:
                    queue.Enqueue(command);
                    break;
            }
        }
    }
}