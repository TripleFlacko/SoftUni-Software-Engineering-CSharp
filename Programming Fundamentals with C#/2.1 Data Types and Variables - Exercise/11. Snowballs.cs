using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var bestSnow = 0;
        var bestTime = 0;
        var bestQuality = 0;
        BigInteger bestValue = 0;

        for (int i = 0; i < n; i++)
        {
            var snowballSnow = int.Parse(Console.ReadLine());
            var snowballTime = int.Parse(Console.ReadLine());
            var snowballQuality = int.Parse(Console.ReadLine());
            var snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue > bestValue)
            {
                bestValue = snowballValue;
                bestSnow = snowballSnow;
                bestTime = snowballTime;
                bestQuality = snowballQuality;
            }
        }
        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }
}