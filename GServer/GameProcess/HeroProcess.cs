using GServer.Models.Heroes;
using System;

namespace GServer.GameProcess
{
    public class HeroProcess
    {
        public Hero? GetRandomHero()
        {
            Random random = new Random();
            HeroType type = (HeroType)random.Next(0, Enum.GetValues(typeof(HeroType)).Length);

            switch (type)
            {
                case HeroType.ENCHANTRESS: return new Enchantress();
                case HeroType.SOLDEROFFORTUNE: return new Solder();
                case HeroType.KNIGHT: return new Knight();
                case HeroType.BARD: return new Bard();
                case HeroType.CRUSADER: return new Crusader();
                case HeroType.NECROMANCER: return new Necromancer();
                case HeroType.MAG: return new Mag();
                case HeroType.GOBLIN: return new Goblin();
                default: return null;
            }
        }
    }
}
