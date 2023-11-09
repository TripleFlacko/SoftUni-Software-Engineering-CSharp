using System;

namespace _11.Refactor_Volume_of_Pyramid

{
    class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var volume = (length * width * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}