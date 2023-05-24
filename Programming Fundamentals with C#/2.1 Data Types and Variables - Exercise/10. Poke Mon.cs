using System;

class Program
{
    static void Main()
    {
        var powerN = int.Parse(Console.ReadLine());
        var distanceM = int.Parse(Console.ReadLine());
        var exhaustionY = int.Parse(Console.ReadLine());

        var pokeCounter = 0;
        var powerOriginal = powerN;
        while (powerN >= distanceM)
        {
            powerN -= distanceM;
            pokeCounter++;
            if (powerN == powerOriginal / 2 && exhaustionY != 0) powerN /= exhaustionY;
        }
        Console.WriteLine($"{powerN}\n{pokeCounter}");
    }
}