using GServer.Models.Heroes;
using GServer.Models;
using GServer.Models.Warriors;
using GServer.Models.Enemies;
using GServer.Models.Сemetery

namespace GServer.Game
{
    public class Adventure
    {
        public IHero Hero { get; set; }
        public Cave Cave { get; set; }
        public ICemtery Cemtery { get; set; }
        public IDragonsDen DragonsDen { get; set; }
        public Adventure(IHero hero, Cave cave, ICemtery cemtery, IDragonsDen dragonsDen)
        {
            Hero = hero;
            Cave = cave;
            Cemtery = cemtery;
            DragonsDen = dragonsDen;
        }

        // Метод сражения
        public void Battle(IWarrior warrior, List<IEnemy> enemies)
        {
            warrior.Attack(enemies);
        }

        // Метод переброски количества врагов
        public void Scroll(IEnemy enemy)
        {
            // Ваша логика переброски количества врагов
        }

        // Метод использования навыка
        public void UseHeroSkill()
        {
            // Ваша логика использования навыка героя
        }

        // Метод использования способности
        public void UseHeroAbility()
        {
            // Ваша логика использования способности героя
        }
    }
}
