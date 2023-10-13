using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var greenLight = int.Parse(Console.ReadLine());
        var freeWindow = int.Parse(Console.ReadLine());
        var queue = new Queue<string>();
        var passedCars = 0;
        string input;

        while (true)
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "green":
                    var greenTemp = greenLight;
                    var carsInQueue = queue.Count();

                    for (int i = 0; i < carsInQueue; i++)
                    {
                        if (greenTemp == 0)
                        {
                            break;
                        }
                        var car = queue.Dequeue();
                        greenTemp -= car.Length;
                        if (greenTemp >= 0)
                        {
                            passedCars++;
                            continue;
                        }
                        else if (greenTemp < 0)
                        {
                            greenTemp += freeWindow;
                            if (greenTemp < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[car.Length + greenTemp]}.");
                                return;
                            }
                            passedCars++;
                            greenTemp = 0;
                        }
                    }
                    break;
                case "END":
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
                    return;
                default:
                    queue.Enqueue(input);
                    break;
            }
        }
    }
}