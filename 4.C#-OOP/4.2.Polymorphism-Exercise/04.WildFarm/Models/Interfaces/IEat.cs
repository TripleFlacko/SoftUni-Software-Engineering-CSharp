namespace WildFarm.Models.Interfaces
{
    public interface IEat
    {
        abstract IReadOnlyCollection<Type> FavouriteFoods { get; }
        void Eat(Food food);
    }
}
