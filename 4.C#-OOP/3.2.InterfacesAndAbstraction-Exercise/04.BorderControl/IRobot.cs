using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public interface IRobot
    {
        public string Name { get; }
        public string ID { get; }
        public bool AccessDenied(string lastDigits);
    }
}
