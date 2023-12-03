namespace VehiclesExtension.Models.Vehicles
{
    public class Truck : Vehicle
    {
        private const double consumptionIncreasement = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, consumptionIncreasement)
        {

        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            base.Refuel(liters * 0.95);
        }
    }
}
