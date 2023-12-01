using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Citizen : IDentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            ID = id;
        }
        public Citizen(string name, int age, string iD, string birthdate) : this(name, age, iD)
        {
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }
        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public bool AccessDenied(string lastDigits)
        {
            if (ID.Substring(ID.Length - lastDigits.Length) == lastDigits)
            {
                return true;
            }

            return false;
        }

        public void BuyFood()
        {
            Food += 10;
        }

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
