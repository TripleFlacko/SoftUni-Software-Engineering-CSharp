using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ");
        var queue = new Queue<string>(input);

        while (queue.Count != 0)
        {
            var commands = Console.ReadLine();
            var commandsSplitted = commands.Split();

            switch (commandsSplitted[0])
            {
                case "Add":
                    var song = commands.Substring(4);
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    break;
                case "Show":
                    Console.WriteLine(string.Join(", ", queue));
                    break;
                case "Play":
                    queue.Dequeue();
                    break;
            }

        }
        Console.WriteLine("No more songs!");
    }
}