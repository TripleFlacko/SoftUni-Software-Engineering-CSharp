using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                var animalInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    switch (input)
                    {
                        case "Cat":
                            var cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            var dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(tomcat);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
