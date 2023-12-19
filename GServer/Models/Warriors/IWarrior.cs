using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public interface IWarrior
    {
        public WarriorType Type { get; }
        public void Attack(EnemyType type, List<IEnemy> enemies);
        public void OpenTreasure();
    }
}
