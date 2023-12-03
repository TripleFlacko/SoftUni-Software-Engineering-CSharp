using _03.Raiding.Factories.Interfaces;
using _03.Raiding.Interfaces;
using _03.Raiding.Models.Heroes;

namespace _03.Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(string name, string type) => type switch
        {
            "Druid" => new Druid(name),
            "Paladin" => new Paladin(name),
            "Rogue" => new Rogue(name),
            "Warrior" => new Warrior(name),
            _ => throw new ArgumentException("Invalid hero!")
        };
    }
}