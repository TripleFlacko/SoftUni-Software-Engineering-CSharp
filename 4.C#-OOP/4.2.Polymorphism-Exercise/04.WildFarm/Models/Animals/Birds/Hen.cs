using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double weightIncreaseMultiplier = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        public override IReadOnlyCollection<Type> FavouriteFoods
            => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };

        public override double WeightIncreaseMultiplier => weightIncreaseMultiplier;
        public override string ProduceSound() => "Cluck";
    }
}
