using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Engine
    {
		private int power;
		private int speed;
        public Engine(int speed, int power)
        {
            Speed = speed;
			Power = power;
        }

        public int Power
		{
			get { return power; }
			set { power = value; }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

	}
}
