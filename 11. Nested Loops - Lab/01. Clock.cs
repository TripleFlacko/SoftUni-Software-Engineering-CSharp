using System;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
        }
    }
}