using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";
        private const string TomcatSound = "MEOW";
        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {

        }

        public override string ProduceSound() => TomcatSound;
    }
}
