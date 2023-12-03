namespace VehiclesExtension.Interfaces
{
    public interface IVehicle
    {
        public string Drive(double distance);
        public void Refuel(double liters);
        public string DriveEmpty(double distance);
    }
}
