using GServer.Models.Enemies;
using GServer.Models.Сemetery;

namespace GServer.Models.Warriors
{
    public class Mage : Warrior, IWarrior
    {
        public Mage()
        {
            Type = WarriorType.Mage;
        }
        public override bool Attack(List<Enemy> enemies, Cave cave, ICemetery cemetery)
        {
            bool hasDefeatedAny = false;
            List<Enemy> enemiesCopy = new(enemies);
            foreach (var enemy in enemiesCopy)
            {
                if ((enemy.Type == EnemyType.Skeleton || enemy.Type == EnemyType.Goblin) && !hasDefeatedAny)
                {
                    cave.Enemies.Remove(enemy);
                    hasDefeatedAny = true;
                }
                else if (enemy.Type == EnemyType.Slime)
                {
                    cave.Enemies.RemoveAll(enemy => enemy.Type == EnemyType.Goblin);
                    hasDefeatedAny = true;
                }
            }
            if (hasDefeatedAny)
            {
                cemetery.AddWarrior(this);
            }
            return hasDefeatedAny;
        }
    }
}