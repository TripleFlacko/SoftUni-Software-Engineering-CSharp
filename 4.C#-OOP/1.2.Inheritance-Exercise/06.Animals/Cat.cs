using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        private const string CatSound = "Meow meow";
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound() => CatSound;
    }
}
