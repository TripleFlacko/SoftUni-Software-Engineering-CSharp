using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public bool SameYear(string year)
        {
            if (Birthdate.Substring(Birthdate.Length - year.Length) == year)
            {
                return true;
            }
            return false;
        }
    }
}
