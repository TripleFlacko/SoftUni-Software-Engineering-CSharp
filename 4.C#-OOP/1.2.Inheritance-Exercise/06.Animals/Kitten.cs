using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string KittenGender = "Female";
        private const string KittenSound = "Meow";
        public Kitten(string name, int age) : base(name, age, KittenGender)
        {

        }

        public override string ProduceSound() => KittenSound;
    }
}
