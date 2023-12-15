using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public interface IWarrior
    {
        public void Attack(List<IEnemy> enemys);
        public void OpenTreasure();
    }
}
