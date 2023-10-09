using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var stack = new Stack<int>(input);
        var rackCapacity = int.Parse(Console.ReadLine());
        var fullRacks = 1;
        var loopLimiter = stack.Count;

        var clothesValue = 0;

        for (int i = 0; i < loopLimiter; i++)
        {
            if (clothesValue + stack.Peek() <= rackCapacity)
            {
                clothesValue += stack.Pop();
            }
            else
            {
                fullRacks++;
                clothesValue = stack.Pop();
            }
        }
        Console.WriteLine(fullRacks);
    }
}