using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public class Robot : IDentifiable
    {
        public Robot(string name, string iD)
        {
            Name = name;
            ID = iD;
        }

        public string Name { get; private set; }

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