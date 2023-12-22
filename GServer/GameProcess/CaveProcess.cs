using GServer.Models;
using GServer.Models.Enemies;
using GServer.Models.Heroes;
using GServer.Models.Warriors;
using GServer.Models.Сemetery;

namespace GServer.GameProcess;
public class CaveProcess : ICaveProcess
{
    private List<IWarrior> _crew;
    private List<IEnemy> _enemies;
    private Cave _cave;
    private IHero _hero;
    private ICemetery _cemetery;

    private const int maxCaveLvl = 9;

    public int CaveLvl { get; set; }
    public CaveProcess(IHero hero, List<IWarrior> crew, List<IEnemy> enemies, int caveLvl, Cave cave, ICemetery cemetery)
    {
        _cemetery = cemetery;
        _crew = crew;
        _cave = cave;
        _hero = hero;
        _enemies = enemies;
        CaveLvl = caveLvl;
    }
    public void MonsterPhase(IWarrior warrior, List<Enemy> enemies)
    {
        if (warrior.Attack(enemies, _cave, _cemetery))
        {
            _crew.Remove(warrior);
        }
        if(warrior.Type == WarriorType.Scroll)
        {
            
        }
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
