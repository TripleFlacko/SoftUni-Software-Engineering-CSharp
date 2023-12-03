using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double weightIncreaseMultiplier = 0.40;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Meat) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;
        public override string ProduceSound() => "Woof!";
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
