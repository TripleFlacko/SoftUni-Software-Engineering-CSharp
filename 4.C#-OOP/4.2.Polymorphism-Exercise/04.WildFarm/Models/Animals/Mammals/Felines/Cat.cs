using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double weightIncreaseMultiplier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Vegetable), typeof(Meat) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;

        public override string ProduceSound() => "Meow";
    }
}
