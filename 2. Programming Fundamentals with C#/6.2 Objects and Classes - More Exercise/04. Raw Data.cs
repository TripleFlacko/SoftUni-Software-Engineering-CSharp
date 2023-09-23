using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        while (true)
        {
            var input = Console.ReadLine().Split().ToList();
            if (input[0] == "fragile")
            {
                List<Car> fragileList = cars
                    .Where(x => x.Cargo.Type == "fragile")
                    .Where(x => x.Cargo.Weight < 1000)
                    .ToList();

                foreach (var car in fragileList)
                {
                    Console.WriteLine(car.Model);
                }
                break;
            }
            else if (input[0] == "flamable")
            {
                List<Car> flamableList = cars
                    .Where(x => x.Cargo.Type == "flamable")
                    .Where(x => x.Engine.Power > 250)
                    .ToList();

                foreach (var car in flamableList)
                {
                    Console.WriteLine(car.Model);
                }
                break;
            }
            else
            {
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                var car = new Car(model, new Engine(speed, power), new Cargo(weight, type));
                cars.Add(car);
            }
        }
    }
}
class Car
{
    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
}
class Engine
{
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }

    public int Speed { get; set; }
    public int Power { get; set; }
}
class Cargo
{
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
    public int Weight { get; set; }
    public string Type { get; set; }
}