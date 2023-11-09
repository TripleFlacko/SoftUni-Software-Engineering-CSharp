using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Car
    {
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires;

		public Tire[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}


		public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
			Engine = engine;
			Cargo = cargo;
			Tires = tires;
        }
        public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}


		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

	}
}
