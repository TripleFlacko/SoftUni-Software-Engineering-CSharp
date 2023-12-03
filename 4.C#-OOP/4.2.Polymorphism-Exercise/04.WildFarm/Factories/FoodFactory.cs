using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public Food CreateFood(string[] foodInfo) => foodInfo[0] switch
        {
            "Vegetable" => new Vegetable(int.Parse(foodInfo[1])),
            "Fruit" => new Fruit(int.Parse(foodInfo[1])),
            "Meat" => new Meat(int.Parse(foodInfo[1])),
            "Seeds" => new Seeds(int.Parse(foodInfo[1])),
        };
    }
}
