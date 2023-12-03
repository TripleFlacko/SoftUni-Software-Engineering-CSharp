using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals.Mammals.Felines;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string[] animalInfo) => animalInfo[0] switch
        {
            "Owl" => new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3])),
            "Hen" => new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3])),
            "Mouse" => new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]),
            "Dog" => new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]),
            "Cat" => new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]),
            "Tiger" => new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4])
        };
    }
}
