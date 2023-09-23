using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        List<Cars> cars = new List<Cars>();
        List<Trucks> trucks = new List<Trucks>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            List<string> input = command.Split('/').ToList();

            string type = input[0];
            string brand = input[1];
            string model = input[2];
            int weight = int.Parse(input[3]);
            int horsePower = int.Parse(input[3]);

            switch (type)
            {
                case "Truck":

                    Trucks truck = new Trucks(brand, model, weight);
                    trucks.Add(truck);
                    break;

                case "Car":

                    Cars car = new Cars(brand, model, horsePower);
                    cars.Add(car);
                    break;
            }
        }
        catalog.Trucks = trucks;
        catalog.Cars = cars;

        catalog.Cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
        catalog.Trucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();

        PrintAll(catalog);
    }
    private static void PrintAll(Catalog catalog)
    {
        if (catalog.Cars.Count != 0)
        {
            Console.WriteLine("Cars:");
            for (int i = 0; i < catalog.Cars.Count; i++)
            {
                Console.WriteLine($"{catalog.Cars[i].Brand}: {catalog.Cars[i].Model} - {catalog.Cars[i].HorsePower}hp");
            }
        }
        if (catalog.Trucks.Count != 0)
        {
            Console.WriteLine("Trucks:");
            for (int i = 0; i < catalog.Trucks.Count; i++)
            {
                Console.WriteLine($"{catalog.Trucks[i].Brand}: {catalog.Trucks[i].Model} - {catalog.Trucks[i].Weight}kg");
            }
        }
    }
}
class Trucks
{
    public Trucks(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
class Cars
{
    public Cars(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
class Catalog
{
    public List<Cars>? Cars { get; set; }
    public List<Trucks>? Trucks { get; set; }
}