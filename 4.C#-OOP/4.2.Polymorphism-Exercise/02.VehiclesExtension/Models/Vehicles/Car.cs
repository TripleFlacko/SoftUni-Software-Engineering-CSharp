using _01.Vehicles.Models;

namespace VehiclesExtension.Models.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double consumptionIncreasement) : base(fuelQuantity, fuelConsumption, consumptionIncreasement)
        {
        }
    }
}
