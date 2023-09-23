using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var savings = double.Parse(Console.ReadLine());
        var initialQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
        var currentQuality = new List<int>(initialQuality);

        Calculations(ref savings, initialQuality, currentQuality);

        Console.WriteLine(string.Join(' ', currentQuality));
        Console.WriteLine($"Gabsy has {savings:F2}lv.");
    }

    static void Calculations(ref double savings, List<int> initialQuality, List<int> currentQuality)
    {
        string command;
        while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            for (int i = 0; i < initialQuality.Count; i++)
            {
                currentQuality[i] -= int.Parse(command);

                if (currentQuality[i] <= 0)
                {
                    if (savings - initialQuality[i] * 3 >= 0)
                    {
                        savings -= initialQuality[i] * 3;
                        currentQuality[i] = initialQuality[i];
                    }
                    else
                    {
                        initialQuality.RemoveAt(i);
                        currentQuality.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}