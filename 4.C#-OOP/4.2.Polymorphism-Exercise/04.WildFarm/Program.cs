using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var animalInfo = command.Split();
                var foodInfo = Console.ReadLine().Split();

                var animalFactory = new AnimalFactory();
                var foodFactory = new FoodFactory();

                var animal = animalFactory.CreateAnimal(animalInfo);
                Console.WriteLine(animal.ProduceSound());
                animals.Add(animal);
                try
                {
                    var food = foodFactory.CreateFood(foodInfo);
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
