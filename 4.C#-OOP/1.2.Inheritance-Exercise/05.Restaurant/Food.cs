using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Food : Product
    {
        protected Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }
}
