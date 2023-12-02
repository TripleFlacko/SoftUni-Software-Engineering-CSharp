using Animals;

namespace _02.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return "DJAAF";
        }
    }
}
