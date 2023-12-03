namespace VehiclesExtension.Models.Vehicles
{
    public class Car : Vehicle
    {
        private const double consumptionIncreasement = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, consumptionIncreasement)
        {

        }
    }
}
