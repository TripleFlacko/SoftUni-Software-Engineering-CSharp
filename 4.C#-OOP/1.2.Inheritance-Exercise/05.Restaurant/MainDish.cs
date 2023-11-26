using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class MainDish : Food
    {
        protected MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}
