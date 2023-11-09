namespace _07.RawData
{
    internal class Program
    {
        static void Main()
        {
            var cars = new List<Car>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split().ToArray();
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tire1Pressure = double.Parse(carInfo[5]);
                var tire1Age = int.Parse(carInfo[6]);
                var tire2Pressure = double.Parse(carInfo[7]);
                var tire2Age = int.Parse(carInfo[8]);
                var tire3Pressure = double.Parse(carInfo[9]);
                var tire3Age = int.Parse(carInfo[10]);
                var tire4Pressure = double.Parse(carInfo[11]);
                var tire4Age = int.Parse(carInfo[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tires = new Tire[]
                {
                    new Tire(tire1Pressure, tire1Age),
                    new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire3Age),
                    new Tire(tire4Pressure, tire4Age),
                };

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string type = Console.ReadLine();
            if (type == "fragile")
            {
                cars = cars.Where(car => car.Cargo.Type == type && car.Tires.Any(x => x.Pressure < 1)).ToList();
            }
            else
            {
                cars = cars.Where(car => car.Cargo.Type == type && car.Engine.Power > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}