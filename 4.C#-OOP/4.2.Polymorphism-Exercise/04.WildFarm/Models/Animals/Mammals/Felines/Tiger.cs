using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private const double weightIncreaseMultiplier = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Meat) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;
        public override string ProduceSound() => "ROAR!!!";
    }
}
