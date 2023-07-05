using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehicle> catalogue = new List<Vehicle>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            AddVehicle(catalogue, input);
        }

        string input2;
        while ((input2 = Console.ReadLine()) != "Close the Catalogue")
        {
            PrintVehicleInfor(catalogue, input2);
        }

        double averageHPCars = catalogue
            .Where(c => c.Type == "Car")
            .Select(c => c.HorsePower)
            .DefaultIfEmpty()
            .Average();
        double averageHPTrucks = catalogue
            .Where(c => c.Type == "Truck")
            .Select(c => c.HorsePower)
            .DefaultIfEmpty()
            .Average();

        Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");
    }

    private static void AddVehicle(List<Vehicle> catalogue, string input)
    {
        var vehicleInfo = input.Split().ToList();
        string type = vehicleInfo[0];
        string model = vehicleInfo[1];
        string color = vehicleInfo[2];
        double horsePower = double.Parse(vehicleInfo[3]);

        Vehicle vehicle = new Vehicle(type, model, color, horsePower);
        catalogue.Add(vehicle);
    }

    private static void PrintVehicleInfor(List<Vehicle> catalogue, string input2)
    {
        Vehicle vehicle = catalogue.Find(c => c.Model == input2);
        Console.WriteLine($"Type: {vehicle.Type}");
        Console.WriteLine($"Model: {vehicle.Model}");
        Console.WriteLine($"Color: {vehicle.Color}");
        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
    }
}
class Vehicle
{
    public Vehicle(string type, string model, string color, double horsePower)
    {
        Type = char.ToUpper(type[0]) + type.Substring(1);
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }
    public double HorsePower { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
}