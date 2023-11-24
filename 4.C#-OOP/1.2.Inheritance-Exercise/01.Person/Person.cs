using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private byte age;

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Age can't be negative!");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
