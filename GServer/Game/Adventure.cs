using GServer.Models.Heroes;
using GServer.Models;
using GServer.Models.Warriors;
using GServer.Models.Enemies;

namespace GServer.Game
{
    public class Adventure
    {
        public IHero Hero { get; set; }
        public Cave Cave { get; set; }
        public ICemtery Cemtery { get; set; }
        public IDragonsDen DragonsDen { get; set; }
        public Adventure(IHero Hero, Cave Cave, ICemtery Cemtery, IDragonsDen DragonsDen)
        {

        }
        //Метод сражения
        public Battle(IWarrior Warrior, List<IEnemy> Enemies)
        {
            Warrior.Attack(Enemies);
        }
        //Метод переброски количества врагов
        public Scroll(IEnemy Enemy)
        {
        }
        //Метод использования навыка
        public UseHeroSkill()
        {
        }
        //Метод использования способность
        public UseHeroAbility()
        {
        }
    }
}
