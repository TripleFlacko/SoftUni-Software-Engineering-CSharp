using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double weightIncreaseMultiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;
        public override string ProduceSound() => "Squeak";
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
