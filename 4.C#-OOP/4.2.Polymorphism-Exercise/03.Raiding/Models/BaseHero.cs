using _03.Raiding.Interfaces;

namespace _03.Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; set; }
        public int Power { get; set; }
        public abstract string CastAbility();
    }
}
