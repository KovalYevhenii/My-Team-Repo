using GServer.Models.Artifacts;
using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Cleric : Warrior, IWarrior
    {
        public Cleric()
        {
            Type = WarriorType.Cleric;
        }

        public override bool Attack(Enemy enemy)
        {
            return enemy.Type == EnemyType.Goblin || enemy.Type == EnemyType.Slime || enemy.Type == EnemyType.Skeleton;
        }
 
        public override ArtifactBase OpenTreasure(List<ArtifactBase> artifacts)
        {
            throw new NotImplementedException();
        }

    }
}
