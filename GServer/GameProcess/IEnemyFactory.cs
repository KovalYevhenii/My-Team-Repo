using GServer.Models.Enemies;
namespace GServer.GameProcess;
public interface IEnemyFactory
{
    IEnemy CreateEnemy(EnemyType type);
    IEnemy GenerateRandomEnemy();
}
