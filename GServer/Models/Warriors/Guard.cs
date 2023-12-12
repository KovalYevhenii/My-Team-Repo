using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Guard : Warrior, IWarrior
    {
        public Guard()
        {
            Type = WarriorType.Guard;
        }
        public void Attack(IList<IEnemy> enemies)
        {
            throw new NotImplementedException();
        }
        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }
    }
}
