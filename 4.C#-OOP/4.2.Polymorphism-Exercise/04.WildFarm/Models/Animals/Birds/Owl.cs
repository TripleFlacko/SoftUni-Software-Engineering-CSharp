using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double weightIncreaseMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Meat) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;

        public override string ProduceSound() => "Hoot Hoot";
    }
}
