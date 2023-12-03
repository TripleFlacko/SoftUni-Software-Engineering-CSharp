using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal, IEat
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightIncreaseMultiplier { get; }

        public abstract IReadOnlyCollection<Type> FavouriteFoods { get; }

        public void Eat(Food food)
        {
            if (!FavouriteFoods.Any(type => type == food.GetType()))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            Weight += food.Quantity * WeightIncreaseMultiplier;
            FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
