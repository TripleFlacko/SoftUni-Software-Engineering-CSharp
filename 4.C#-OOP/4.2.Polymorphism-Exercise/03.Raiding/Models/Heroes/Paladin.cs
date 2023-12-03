namespace _03.Raiding.Models.Heroes
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
