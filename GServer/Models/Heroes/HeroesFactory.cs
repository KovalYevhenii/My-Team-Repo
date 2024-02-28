using GServer.Models.Warriors;

namespace GServer.Models.Heroes
{
    public class HeroesFactory
    {
        private Hero hero;

        public HeroesFactory(HeroType type)
        {
            switch (type)
            {
                case HeroType.BARD:
                    Hero = new Bard();
                    break;
                case HeroType.KNIGHT:
                    Hero = new Knight();
                    break;
                case HeroType.MAGE:
                    Hero = new Mage();
                    break;
                case HeroType.NECROMANCER:
                    Hero = new Necromancer();
                    break;
                case HeroType.ENCHANTRESS:
                    Hero = new Enchantress();
                    break;
                default:
                    Hero = new Enchantress();
                    break;
            }
        }

        protected Hero Hero { get => hero; set => hero = value; }
    }
}
