using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            Name = name;
            Dough = dough;
            Toppings = toppings;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public Dough Dough { get; set; }
        public List<Topping> Toppings
        {
            get
            {
                return toppings;
            }
            private set
            {
                if (value.Count < 0 || value.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                else
                {
                    toppings = value;
                }
            }
        }
        public double TotalCalories()
        {
            double totalCalories = 0;
            Toppings.ForEach(topping => totalCalories += topping.TotalCalories);
            totalCalories += Dough.TotalCalories;
            return totalCalories;
        }
        public override string ToString()
        {
            return $"{Name} - {TotalCalories():F2} Calories.";
        }
    }
}
