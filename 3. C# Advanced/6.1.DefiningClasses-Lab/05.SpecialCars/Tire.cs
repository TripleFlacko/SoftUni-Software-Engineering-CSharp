using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManufacturer;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
			Year = year;
			Pressure = pressure;
        }
        private int year;
		private double pressure;

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

	}
}
