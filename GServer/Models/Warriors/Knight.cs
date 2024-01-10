using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Knight : Warrior, IWarrior
    {
        public Knight()
        {
            Type = WarriorType.Knight;
        }

        public void Attack(EnemyType enemyType)
        {
            throw new NotImplementedException();
        }

        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }
    }
}
