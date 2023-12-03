using _03.Raiding.Interfaces;

namespace _03.Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        IHero CreateHero(string name, string type);
    }
}
