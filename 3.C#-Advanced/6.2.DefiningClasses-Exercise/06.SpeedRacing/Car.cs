using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

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


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

	}
}
