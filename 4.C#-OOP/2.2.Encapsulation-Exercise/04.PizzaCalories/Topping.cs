using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private int grams;
        private string toppingType;

        private Dictionary<string, double> toppingTypeCalories
            = new Dictionary<string, double> { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };

        public Topping(string toppingType, int grams)
        {
            ToppingType = toppingType;
            Grams = grams;
        }

        public int Grams
        {
            get
            {
                return grams;
            }
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
                }
                else
                {
                    grams = value;
                }
            }
        }
        public string ToppingType
        {
            get
            {
                return toppingType;
            }
            private set
            {
                if (toppingTypeCalories.ContainsKey(value.ToLower()))
                {
                    toppingType = value.ToLower();
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double TotalCalories
        {
            get
            {
                return 2 * Grams * toppingTypeCalories[toppingType];
            }
        }

    }
}
