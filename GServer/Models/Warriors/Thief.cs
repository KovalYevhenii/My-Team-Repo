using GServer.Models.Enemies;
using GServer.Models.Сemetery;

namespace GServer.Models.Warriors;
public class Thief : Warrior, IWarrior
{
    public Thief()
    {
        Type = WarriorType.Thief;
    }

    public override bool Attack(List<IEnemy> enemies, Cave cave, ICemetery cemetery)
    {
        bool hasDefeatedAny = false;
        List<IEnemy> enemiesCopy = new(enemies);

        foreach (var enemy in enemiesCopy)
        {
            if ((enemy.Type == EnemyType.Skeleton || enemy.Type == EnemyType.Slime || enemy.Type == EnemyType.Goblin) && !hasDefeatedAny)
            {
                cave.Enemies.Remove(enemy);
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
