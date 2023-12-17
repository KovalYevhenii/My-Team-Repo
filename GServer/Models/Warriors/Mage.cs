using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Mage : Warrior, IWarrior
    {
        public Mage()
        {
            Type = WarriorType.Mage;
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
