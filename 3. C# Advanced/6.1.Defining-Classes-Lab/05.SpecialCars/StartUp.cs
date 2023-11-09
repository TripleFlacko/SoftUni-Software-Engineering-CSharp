using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            var listTires = new List<Tire[]>();
            var listEngines = new List<Engine>();
            var listCars = new List<Car>();

            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                var tires = command.Split().ToArray();
                var tireYear1 = int.Parse(tires[0]);
                var pressure1 = double.Parse(tires[1]);
                var tireYear2 = int.Parse(tires[2]);
                var pressure2 = double.Parse(tires[3]);
                var tireYear3 = int.Parse(tires[4]);
                var pressure3 = double.Parse(tires[5]);
                var tireYear4 = int.Parse(tires[6]);
                var pressure4 = double.Parse(tires[7]);

                var tire1 = new Tire(tireYear1, pressure1);
                var tire2 = new Tire(tireYear2, pressure2);
                var tire3 = new Tire(tireYear3, pressure3);
                var tire4 = new Tire(tireYear4, pressure4);

                listTires.Add(new Tire[] {tire1, tire2, tire3, tire4 });
            }
            while ((command = Console.ReadLine()) != "Engines done")
            {
                var engines = command.Split().ToArray();
                var horsePower = int.Parse(engines[0]);
                var cubicCapacity = double.Parse(engines[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                listEngines.Add(engine);
            }
            while ((command = Console.ReadLine()) != "Show special")
            {
                var carInput = command.Split().ToArray();
                var make = carInput[0];
                var model = carInput[1];
                var carYear = int.Parse(carInput[2]);
                var fuelQuantity = double.Parse(carInput[3]);
                var fuelConsumption = double.Parse(carInput[4]);
                var engineIndex = int.Parse(carInput[5]);
                var tireIndex = int.Parse(carInput[6]);

                var car = new Car(make, model, carYear, fuelQuantity, fuelConsumption, listEngines[engineIndex], listTires[tireIndex]);

                listCars.Add(car);
            }
            var specialCars = new List<Car>();
            foreach (var car in listCars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && (car.Tires.Sum(x => x.Pressure) >= 9 && car.Tires.Sum(x => x.Pressure) <= 10))
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }
            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
