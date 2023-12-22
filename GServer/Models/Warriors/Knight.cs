using GServer.Models.Enemies;
namespace GServer.Models.Warriors
{
    public class Knight : Warrior, IWarrior
    {
        public Knight()
        {
            Type = WarriorType.Knight;
        }
        public override bool Attack(Enemy enemy)
        {
            return enemy.Type == EnemyType.Goblin || enemy.Type == EnemyType.Slime || enemy.Type == EnemyType.Skeleton;
        }
    }
}
