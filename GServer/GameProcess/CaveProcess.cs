using GServer.Models.Enemies;
using GServer.Models.Heroes;
using GServer.Models.Warriors;
namespace GServer.GameProcess;
public class CaveProcess : ICaveProcess
{
    private List<IWarrior> _crew;
    private List<IEnemy> _enemies;
    private IHero _hero;
    private IEnemyFactory _enemyFactory;

    public int CaveLvl { get; set; } = 1;
    public CaveProcess(IHero hero, List<IEnemy> enemies, IEnemyFactory factory)
    {
        _hero = hero;
        _enemyFactory = factory;
        _enemies = enemies;
    }
    public void MonsterPhase(List<IWarrior> warriors, List<IEnemy> enemies)
    {

        //if(EnemyType.Goblin )
        _enemies = GenerateEnemies();
    }
    public void EarningPhase()
    {

    }
    public void DragonPhase()
    {

    }
    public void ReGroupPhase()
    {

    }

    private List<IEnemy> GenerateEnemies()
    {
        var enemies = new List<IEnemy>();
        var maxCaveLvl = 9;
        var enemyCount = Math.Min(CaveLvl, maxCaveLvl);

        for (int i = 0; i < enemyCount; i++)
        {
            enemies.Add(_enemyFactory.GenerateRandomEnemy());
        }
        return enemies;
    }
}
