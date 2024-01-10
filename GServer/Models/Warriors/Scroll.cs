using GServer.Models.Enemies;
using GServer.Models.Сemetery;
namespace GServer.Models.Warriors;
public class Scroll : Warrior, IWarrior
{
    private Random _random = new();
    public Scroll()
    {
        Type = WarriorType.Scroll;
    }
    public override bool Attack(List<Enemy> enemies, Cave cave, ICemetery cemetery)
    {
        return false;
    }
    public (List<IWarrior>, List<IEnemy>) Activate(List<IWarrior> chosenWarriors, List<IEnemy> chosenEnemies)
    {
        var newEnemies = GenerateRandomEnemies(chosenEnemies);
        var newWarriors = GenerateRandomWarriors(chosenWarriors);
        return(newWarriors, newEnemies);
    }
    private List<IWarrior> GenerateRandomWarriors(List<IWarrior> warriors)
    {
        var newWarriors = new List<IWarrior>();
        var warriorsAmount = warriors.Count;

        for (int i = 0; i < warriorsAmount; i++)
        {
            var warriorType = (WarriorType)_random.Next(Enum.GetNames(typeof(WarriorType)).Length);
            switch (warriorType)
            {
                case WarriorType.Cleric:
                    newWarriors.Add(new Cleric());
                    break;
                case WarriorType.Guard:
                    newWarriors.Add(new Guard());
                    break;
                case WarriorType.Mage:
                    newWarriors.Add(new Mage());
                    break;
                case WarriorType.Knight:
                    newWarriors.Add(new Knight());
                    break;
                case WarriorType.Thief:
                    newWarriors.Add(new Thief());
                    break;
                case WarriorType.Scroll:
                    newWarriors.Add(new Scroll());
                    break;
            }
        }
        return newWarriors;
    }
    private List<IEnemy> GenerateRandomEnemies(List<IEnemy> enemies)
    {
        var enemiesAmount = enemies.Count;
        var newEnemies = new List<IEnemy>();
        for (int i = 0; i < enemiesAmount; i++)
        {
            var enemyType = (EnemyType)_random.Next(Enum.GetNames(typeof(EnemyType)).Length);
            newEnemies.Add(new Enemy(enemyType));
        }
        return newEnemies;
    }
}
