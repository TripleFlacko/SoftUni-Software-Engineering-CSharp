using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int space = width * lenght * height;

            while (true)
            {
                string inputBoxes = Console.ReadLine();

                if (inputBoxes == "Done")
                {
                    Console.WriteLine($"{space} Cubic meters left."); break;
                }

                space -= int.Parse(inputBoxes);

                if (space <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more."); break;
                }
            }
        }
    }
}