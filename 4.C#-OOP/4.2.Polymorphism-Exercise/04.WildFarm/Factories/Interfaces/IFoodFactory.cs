using WildFarm.Models;

namespace WildFarm.Factories.Interfaces
{
    public interface IFoodFactory
    {
        Food CreateFood(string[] foodInfo);
    }
}
