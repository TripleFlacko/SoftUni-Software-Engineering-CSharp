using VehiclesExtension.Interfaces;
using VehiclesExtension.Models.Vehicles;

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            var vehicles = new List<IVehicle>();
            for (int i = 0; i < 3; i++)
            {
                vehicles.Add(CreateVehicle(Console.ReadLine().Split()));
            }

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == input[1]);
                try
                {
                    if (input[0] == "Drive")
                    {
                        Console.WriteLine(vehicle.Drive(double.Parse(input[2])));
                    }
                    else if (input[0] == "DriveEmpty")
                    {
                        Console.WriteLine(vehicle.DriveEmpty(double.Parse(input[2])));
                    }
                    else if (input[0] == "Refuel")
                    {
                        vehicle.Refuel(double.Parse(input[2]));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
        public static IVehicle CreateVehicle(string[] vehicleInfo) => vehicleInfo[0] switch
        {
            "Car" => new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3])),
            "Truck" => new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3])),
            "Bus" => new Bus(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3])),
            _ => default,
        };
    }
}
