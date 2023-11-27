using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private int grams;
        private string flourType;
        private string bakingTechnique;

        private Dictionary<string, double> flourTypeCaloriesModifier
            = new Dictionary<string, double> { { "white", 1.5 }, { "wholegrain", 1.0 } };

        private Dictionary<string, double> bakingTechniqueCalories
            = new Dictionary<string, double> { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };

        public Dough(string flourType, string bakingTechnique, int grams)
        {
            FlourType = flourType.ToLower();
            BakingTechnique = bakingTechnique.ToLower();
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public double TotalCalories
        {
            get
            {
                return 2 * Grams * flourTypeCaloriesModifier[flourType] * bakingTechniqueCalories[bakingTechnique];
            }
        }

        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (flourTypeCaloriesModifier.ContainsKey(value))
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                if (bakingTechniqueCalories.ContainsKey(value))
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
    }
}
