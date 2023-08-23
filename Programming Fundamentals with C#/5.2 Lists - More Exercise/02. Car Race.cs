using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(double.Parse).ToList();
        double finishLine = Math.Floor(input.Count() / 2d);
        double firstCarTime = 0;
        double secondCarTime = 0;

        for (int i = 0; i < finishLine; i++)
        {
            if (input[i] == 0)
            {
                firstCarTime *= 0.8;
                continue;
            }
            firstCarTime += input[i];
        }
        for (int i = input.Count - 1; finishLine < i; i--)
        {
            if (input[i] == 0)
            {
                secondCarTime *= 0.8;
                continue;
            }
            secondCarTime += input[i];
        }
        double winnerTime = firstCarTime < secondCarTime ? firstCarTime : secondCarTime;
        string winnerSide = firstCarTime < secondCarTime ? "left" : "right";

        if (winnerTime % Math.Floor(winnerTime) == 0)
        {
            Console.WriteLine($"The winner is {winnerSide} with total time: {winnerTime}");
        }
        else
        {
            Console.WriteLine($"The winner is {winnerSide} with total time: {winnerTime:f1}");
        }
    }
}