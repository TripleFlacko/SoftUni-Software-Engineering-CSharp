using _01.Vehicles.Interfaces;
using _01.Vehicles.Models.Vehicles;

namespace _01.Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            var vehicles = new List<IVehicle>();

            var input = Console.ReadLine().Split();
            vehicles.Add(new Car(double.Parse(input[1]), double.Parse(input[2]), 0.9));

            input = Console.ReadLine().Split();
            vehicles.Add(new Truck(double.Parse(input[1]), double.Parse(input[2]), 1.6));

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();

                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == input[1]);
                try
                {
                    if (input[0] == "Drive")
                    {
                        Console.WriteLine(vehicle.Drive(double.Parse(input[2])));
                    }
                    else
                    {
                        vehicle.Refuel(double.Parse(input[2]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
