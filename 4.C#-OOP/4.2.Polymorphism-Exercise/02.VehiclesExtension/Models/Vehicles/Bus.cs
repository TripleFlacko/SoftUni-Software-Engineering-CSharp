namespace VehiclesExtension.Models.Vehicles
{
    public class Bus : Vehicle
    {
        private const double consumptionIncreasement = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, consumptionIncreasement)
        {

        }
    }
}
