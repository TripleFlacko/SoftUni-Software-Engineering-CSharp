namespace _06.SpeedRacing
{
    internal class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);

                cars[model] = new Car(fuelAmount, fuelConsumption);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var driveInput = command.Split().ToArray();
                var driveCarModel = driveInput[1];
                var amountOfKM = double.Parse(driveInput[2]);

                cars[driveCarModel].Drive(amountOfKM);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}