using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Guard : Warrior, IWarrior
    {
        public Guard()
        {
            WarriorType type = WarriorType.GUARD;
        }
        public void Attack(IList<IEnemy> enemies)
        {
            throw new NotImplementedException();
        }

        public bool Attack(Enemy enemy)
        {
            throw new NotImplementedException();
        }

        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }

        WarriorType IWarrior.GetType()
        {
            throw new NotImplementedException();
        }
    }
}
