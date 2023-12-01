using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public interface ICitizen
    {
        public string Name { get; }
        public int Age { get; }
        public string ID { get; }
        public bool AccessDenied(string lastDigits);
    }
}
