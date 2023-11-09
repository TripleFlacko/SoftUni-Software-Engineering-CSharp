using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Car
    {
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

        public Car(double fuelAmount, double fuelConsumptionPerKilometer)
        {
			FuelAmount = fuelAmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
			TravelledDistance = 0;
        }
        public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}


		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}


		public double FuelAmount
        {
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}

		public void Drive(double amountOfKM)
		{
			if (FuelAmount - fuelConsumptionPerKilometer * amountOfKM >= 0)
			{
				FuelAmount -= fuelConsumptionPerKilometer * amountOfKM;
				TravelledDistance += amountOfKM;
            }
			else
			{
                Console.WriteLine("Insufficient fuel for the drive");
            }
		}
	}
}
