using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }
        public void Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;
            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
