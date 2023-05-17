using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double size = double.Parse(Console.ReadLine());

                double result = size * size;

                Console.WriteLine("{0:0.000}", result);

            }

            else if (shape == "rectangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());

                double result = size * size2;

                Console.WriteLine("{0:0.000}", result);
            }

            else if (shape == "circle")
            {
                double size = double.Parse(Console.ReadLine());

                double result = size * size * Math.PI;

                Console.WriteLine("{0:0.000}", result);
            }

            else if (shape == "triangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());

                double result = size * size2 / 2;

                Console.WriteLine("{0:0.000}", result);
            }
        }
    }
}