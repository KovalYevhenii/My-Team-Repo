using GServer.Models.Heroes;

namespace GServer.GameProcess
{
    public class HeroProcess
    {
        public IHero GetRandomHero()
        {
            return new Enchantress();
        }
    }
}
