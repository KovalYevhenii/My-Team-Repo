using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Cleric : Warrior, IWarrior
    {
        public Cleric()
        {
            Type = WarriorType.Cleric;
        }

        public void Attack(EnemyType type, List<IEnemy> enemies)
        {
            var enemy = enemies.FirstOrDefault(e => e.Type == type);
            if (enemy != null)
            {
                enemies.Remove(enemy);
            }
        }

        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }

    }
}
