using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04.BorderControl
{
    public class Person : IRobot, ICitizen
    {
        public Person(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public Person(string name, int age, string id) : this(name, id)
        {
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public bool AccessDenied(string lastDigits)
        {
            if (ID.Substring(ID.Length - lastDigits.Length) == lastDigits)
            {
                return true;
            }

            return false;
        }
    }
}
