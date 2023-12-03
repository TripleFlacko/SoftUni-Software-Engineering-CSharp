using _03.Raiding.Factories;
using _03.Raiding.Interfaces;

namespace _03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var heroes = new List<IHero>();
            var numberOfHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfHeroes; i++)
            {
                var name = Console.ReadLine();
                var type = Console.ReadLine();

                var heroFactory = new HeroFactory();
                try
                {
                    var hero = heroFactory.CreateHero(name, type);
                    if (hero != null)
                    {
                        heroes.Add(hero);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
            var sum = 0;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                sum += hero.Power;
            }
            var bossHealth = int.Parse(Console.ReadLine());
            Console.WriteLine(bossHealth <= sum ? "Victory!" : "Defeat...");
        }
    }
}
