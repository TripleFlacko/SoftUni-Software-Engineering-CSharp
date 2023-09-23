using System;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var biggestVolume = 0d;
        var biggestKeg = String.Empty;

        for (int i = 0; i < num; i++)
        {
            var modelName = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var volume = Math.PI * Math.Pow(radius, 2) * height;
            if (volume > biggestVolume)
            {
                biggestVolume = volume;
                biggestKeg = modelName;
            }
        }
        Console.WriteLine(biggestKeg);
    }
}