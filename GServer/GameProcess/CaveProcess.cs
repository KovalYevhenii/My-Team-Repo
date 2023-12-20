using GServer.Models;
using GServer.Models.Enemies;
using GServer.Models.Heroes;
using GServer.Models.Warriors;

namespace GServer.GameProcess;
public class CaveProcess : ICaveProcess
{
    private List<IWarrior> _crew;
    private List<IEnemy> _enemies;
    private Cave _cave;
    private IHero _hero;
    private IEnemyFactory _enemyFactory;

    private const int maxCaveLvl = 9;

    public int CaveLvl { get; set; }
    public CaveProcess(IHero hero, List<IWarrior> crew, List<IEnemy> enemies, IEnemyFactory factory, int caveLvl, Cave cave)
    {
        _crew = crew;
        _cave = cave;
        _hero = hero;
        _enemyFactory = factory;
        _enemies = enemies;
        CaveLvl = caveLvl;
    }
    public void MonsterPhase(IWarrior warrior,List<Enemy> enemies)
    {

        for (int i = 0; i < enemies.Count; i++)
        {

            if (enemies[i].Type == EnemyType.Treasure || enemies[i].Type == EnemyType.Elixir)
                return;

            foreach (var enemy in _cave.Enemies)
            {
                _cave.Enemies.Remove(enemies[i]);
            }
            if (!warrior.Attack(enemies[i]))
                break;
        }
        _crew.Remove(warrior);
    }
    private List<IEnemy> GenerateEnemies()
    {
        var enemies = new List<IEnemy>();
        var enemyCount = Math.Min(CaveLvl, maxCaveLvl);

        for (int i = 0; i < enemyCount; i++)
        {
            enemies.Add(_enemyFactory.GenerateRandomEnemy());
        }
        return enemies;
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

}
