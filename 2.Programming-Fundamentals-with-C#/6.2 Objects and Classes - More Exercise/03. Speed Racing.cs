using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var carInfo = command.Split().ToArray();

            if (carInfo[0] == "Drive")
            {
                cars
                    .Where(x => x.Model == carInfo[1])
                    .First()
                    .Drive(double.Parse(carInfo[2]));
            }
            else
            {
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double consumption = double.Parse(carInfo[2]);
                var car = new Car(model, fuel, consumption);
                cars.Add(car);
            }

        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.Distance}");
        }
    }
}
class Car
{
    public Car(string model, double fuel, double consumption)
    {
        Model = model;
        Fuel = fuel;
        Consumption = consumption;
        Distance = 0d;
    }
    public string Model { get; set; }
    public double Fuel { get; set; }
    public double Consumption { get; set; }
    public double Distance { get; set; }

    public void Drive(double distance)
    {
        if (Fuel >= distance * Consumption)
        {
            Fuel -= distance * Consumption;
            Distance += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}