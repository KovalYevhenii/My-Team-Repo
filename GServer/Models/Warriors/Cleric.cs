using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public class Cleric : Warrior, IWarrior
    {
        public Cleric()
        {
            type = WarriorType.CLERIC;
        }

        public bool Attack(EnemyType type, List<Enemy> enemies)
        {
            var enemy = enemies.FirstOrDefault(e => e.type == type);
            if (enemy != null)
            {
                enemies.Remove(enemy);
            }
            return true;
        }

        public bool Attack(EnemyType type, List<IEnemy> enemies)
        {
            throw new NotImplementedException();
        }

        public void OpenTreasure()
        {
            throw new NotImplementedException();
        }

        WarriorType IWarrior.GetType()
        {
            return type;
        }
    }
}
