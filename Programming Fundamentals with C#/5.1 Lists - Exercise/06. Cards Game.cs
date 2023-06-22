using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            if (firstHand[0] > secondHand[0])
            {
                FirstHandWins(firstHand, secondHand);
            }
            else if (firstHand[0] < secondHand[0])
            {
                SecondHandWins(firstHand, secondHand);
            }
            else
            {
                Draw(firstHand, secondHand);
            }
            if (firstHand.Count == 0 || secondHand.Count == 0)
            {
                break;
            }
        }
        string winPlayer;
        int sum;

        CheckWhoWins(firstHand, secondHand, out winPlayer, out sum);
        Console.WriteLine($"{winPlayer} player wins! Sum: {sum}");

    }

    private static void CheckWhoWins(List<int> firstHand, List<int> secondHand, out string winPlayer, out int sum)
    {
        winPlayer = string.Empty;
        sum = 0;
        if (firstHand.Count == 0)
        {
            winPlayer = "Second";
            sum = secondHand.Sum();

        }
        else if (secondHand.Count == 0)
        {
            winPlayer = "First";
            sum = firstHand.Sum();
        }
    }

    private static void Draw(List<int> firstHand, List<int> secondHand)
    {
        firstHand.RemoveAt(0);
        secondHand.RemoveAt(0);
    }

    private static void SecondHandWins(List<int> firstHand, List<int> secondHand)
    {
        secondHand.Add(firstHand[0]);
        secondHand.Insert(secondHand.Count - 1, secondHand[0]);
        secondHand.RemoveAt(0);
        firstHand.RemoveAt(0);
    }

    private static void FirstHandWins(List<int> firstHand, List<int> secondHand)
    {
        firstHand.Add(secondHand[0]);
        firstHand.Insert(firstHand.Count - 1, firstHand[0]);
        firstHand.RemoveAt(0);
        secondHand.RemoveAt(0);
    }
}