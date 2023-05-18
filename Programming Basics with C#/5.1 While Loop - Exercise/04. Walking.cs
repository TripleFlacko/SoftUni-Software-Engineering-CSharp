using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;

            while (steps < goal)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int steps2 = int.Parse(Console.ReadLine());
                    steps += steps2;

                    if (steps >= goal)
                    {
                        Console.WriteLine($"Goal reached! Good job!\n{steps - goal} steps over the goal!");
                    }
                    else
                    {
                        Console.WriteLine($"{goal - steps} more steps to reach goal.");
                    }
                    break;
                }
                else
                {
                    steps += int.Parse(input);
                    if (steps >= goal)
                    {
                        Console.WriteLine($"Goal reached! Good job!\n{steps - goal} steps over the goal!");
                        break;
                    }
                }
            }
        }
    }
}