using GServer.Models.Enemies;
using GServer.Models.Сemetery;

namespace GServer.Models.Warriors;
public class Guard : Warrior, IWarrior
{
    public Guard()
    {
        Type = WarriorType.Guard;
    }
    public override bool Attack(List<IEnemy> enemies, Cave cave, ICemetery cemetery)
    {
       int initialCount = cave.Enemies.Count;
        cave.Enemies.RemoveAll(e => e.Type == EnemyType.Slime || e.Type == EnemyType.Goblin || e.Type == EnemyType.Skeleton);
        int finalCount = cave.Enemies.Count;
        if (initialCount > finalCount)
        {
            cemetery.AddWarrior(this);
        }
        return initialCount > finalCount;  // If any enemy was removed, return true
    }
}
