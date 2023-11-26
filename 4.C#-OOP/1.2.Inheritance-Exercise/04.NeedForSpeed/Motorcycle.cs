using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Motorcycle : Vehicle
    {
        protected Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
}
