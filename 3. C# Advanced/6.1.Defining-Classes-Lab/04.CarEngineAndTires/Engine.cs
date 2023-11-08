using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManufacturer;


namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
			HorsePower = horsePower;
			CubicCapacity = cubicCapacity;
        }
        private int horsePower;

		private double cubicCapacity;

		public double CubicCapacity
		{
			get { return cubicCapacity; }
			set { cubicCapacity = value; }
		}

		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}
	}
}
