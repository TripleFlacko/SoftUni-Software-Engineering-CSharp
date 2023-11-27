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
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
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

        public void AddToppings(Topping topping)
        {
            if (toppings.Count < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
        public double TotalCalories()
        {
            double totalCalories = 0;
            toppings.ForEach(topping => totalCalories += topping.TotalCalories);
            totalCalories += Dough.TotalCalories;
            return totalCalories;
        }
        public override string ToString()
        {
            return $"{Name} - {TotalCalories():F2} Calories.";
        }
    }
}
