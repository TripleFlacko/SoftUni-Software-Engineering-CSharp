using System;

class Program
{
    static void Main(string[] args)
    {
        var gasStations = int.Parse(Console.ReadLine());
        var pumps = new Queue<string>();

        for (int i = 0; i < gasStations; i++)
        {
            pumps.Enqueue(Console.ReadLine());
        }
        for (int i = 0; i < gasStations; i++)
        {
            if (CanCompleteCircle(pumps))
            {
                Console.WriteLine(i);
                return;
            }
            pumps.Enqueue(pumps.Dequeue());
        }
    }

    private static bool CanCompleteCircle(Queue<string> pumps)
    {
        var fuel = 0;
        bool canCompleteCircle = true;

        for (int i = 0; i < pumps.Count; i++)
        {
            var gas = pumps.Peek().Split().Select(int.Parse).First();
            var distance = pumps.Peek().Split().Select(int.Parse).Last();
            fuel += gas - distance;

            if (fuel < 0)
            {
                canCompleteCircle = false;
            }
            pumps.Enqueue(pumps.Dequeue());
        }
        return canCompleteCircle;
    }
}