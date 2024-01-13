
using GServer.Models.Enemies;
using GServer.Models.Сemetery;
using System;

namespace GServer.Models.Warriors;
public class Cleric : Warrior, IWarrior
{
    public Cleric()
    {
        Type = WarriorType.Cleric;
    }
    public override bool Attack(List<Enemy> enemies, Cave cave, ICemetery cemetery)
    {
        bool hasDefeatedAny = false;
        List<Enemy> enemiesCopy = new(enemies);

        foreach (var enemy in enemiesCopy)
        {
            if ((enemy.Type == EnemyType.Goblin || enemy.Type == EnemyType.Slime) && !hasDefeatedAny)
            {
                cave.Enemies.Remove(enemy);
                hasDefeatedAny = true;
            }
            else if (enemy.Type == EnemyType.Skeleton)
            {
                cave.Enemies.RemoveAll(enemy => enemy.Type == EnemyType.Skeleton);
                hasDefeatedAny = true;
            }
        }
        if(hasDefeatedAny)
        {
            cemetery.AddWarrior(this);
        }
        return hasDefeatedAny;
    }
}
