using VehiclesExtension.Interfaces;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double consumptionIncreasement;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double consumptionIncreasement)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.consumptionIncreasement = consumptionIncreasement;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double consumption = distance * (FuelConsumption + consumptionIncreasement);
            if (FuelQuantity < consumption)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= consumption;

            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters) => FuelQuantity += liters;
        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
