namespace _01.Vehicles.Models.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double consumptionIncreasement) : base(fuelQuantity, fuelConsumption, consumptionIncreasement)
        {

        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
