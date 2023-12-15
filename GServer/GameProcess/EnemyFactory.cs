using GServer.Models.Enemies;
namespace GServer.GameProcess;
public class EnemyFactory : IEnemyFactory
{
    private readonly Random _random = new();
    private static Dictionary<EnemyType, Func<IEnemy>> enemyTypeMap
        = new Dictionary<EnemyType, Func<IEnemy>>
    {
        { EnemyType.Goblin, () => new Goblin() },
        { EnemyType.Treasure, () => new Treasure() },
        { EnemyType.Skeleton, () => new Skeleton() },
        { EnemyType.Slime, () => new Slime() },
        { EnemyType.Elixir, () =>new Elexir() },
        { EnemyType.Dragon, () => new Dragon() },
    };
    public IEnemy CreateEnemy(EnemyType type)
    {
        if (!Enum.IsDefined(typeof(EnemyType), type))
        {
            throw new ArgumentException("Invalid enemy type.");
        }

        if (!enemyTypeMap.TryGetValue(type, out var creator))
        {
            throw new ArgumentException("Invalid enemy type.");
        }

        return creator();
    }
    public IEnemy GenerateRandomEnemy()
    {
        Array enemyTypes = Enum.GetValues(typeof(EnemyType));
        int index = _random.Next(enemyTypes.Length);
        EnemyType randomType = (EnemyType)enemyTypes.GetValue(index);
        return CreateEnemy(randomType);
    }
}
