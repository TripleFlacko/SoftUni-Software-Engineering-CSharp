using WildFarm.Models;

namespace WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal(string[] animalInfo);
    }
}
