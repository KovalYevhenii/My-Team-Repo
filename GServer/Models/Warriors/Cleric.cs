using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Cleric : Warrior, IWarrior
    {
        public Cleric()
        {
            Type = WarriorType.Cleric;
        }

        public void Attack(IList<IEnemy> enemys)
        {
            throw new NotImplementedException();
        }

        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }
    }
}
