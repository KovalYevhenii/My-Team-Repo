using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Cleric : Warrior, IWarrior
    {
        public Cleric()
        {
            Type = WarriorType.Cleric;
        }

        public void Attack(IList<IEnemy> enemies)
        {

        }
        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }
    }
}
