using GServer.Models;
using GServer.Models.Artifacts;
using GServer.Models.Enemies;
using GServer.Models.Heroes;
using GServer.Models.TheDragonsDen;
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
    private IDragonsDen _dragonsDen;
    public CaveProcess(IHero hero, List<IWarrior> crew, List<IEnemy> enemies, Cave cave, ICemetery cemetery, IDragonsDen dragonsDen)
    {
        _cemetery = cemetery;
        _crew = crew;
        _cave = cave;
        _hero = hero;
        _enemies = enemies;
        _dragonsDen = dragonsDen;
    }
    public void MonsterPhase(IWarrior warrior, List<IEnemy> enemies)
    {
        bool isHeroSkillRequested = false;
        bool isHeroAbilityRequested = false;
        if (warrior.Attack(enemies, _cave, _cemetery))
        {
            _cemetery.AddWarrior(warrior);
            _crew.Remove(warrior);
        }
        if (warrior.Type == WarriorType.Scroll)
        {
            var (newWarriors, newEnemies) = ((Scroll)warrior).Activate(_crew, _cave.Enemies, _dragonsDen);
            _crew = newWarriors;
            _cave.Enemies = newEnemies;
        }
        // In DragonsDen need to check amount to start the battle
        if (isHeroSkillRequested)
        {
            //_hero.SkillAction();  // проверять по навыку героя
        }
        if (isHeroAbilityRequested)
        {
            //_hero.AbilityAction();
        }

        //Or use Hero ability
    }
    public void EarningPhase(IWarrior warrior, List<Enemy> enemies)
    {
        if (warrior.Type == WarriorType.Thief || warrior.Type == WarriorType.Guard)
        {
            foreach (var enemy in enemies.Where(e => e.Type == EnemyType.Treasure))
            {
                var resievedArtifact = warrior.OpenTreasure();
                //присвоить артефакты герою сумка?
            }
        }
        else if (warrior.Type == WarriorType.Cleric || warrior.Type == WarriorType.Knight)
        {
            var treasure = enemies.FirstOrDefault(e => e.Type == EnemyType.Treasure);
            if (treasure != null)
            {
                var resievedArtifact = warrior.OpenTreasure();
            }
        }
        if (warrior != null && enemies.All(e => e.Type == EnemyType.Elixir))
        {
            _cemetery.AddWarrior(warrior);
            _crew.Remove(warrior);

            var elexirs = enemies.Where(e => e.Type == EnemyType.Elixir).ToList();

            foreach (var e in elexirs)
            {
                _cemetery.GetWarrior(warrior);
                _crew.Add(warrior);
            }
        }
    }
    public bool DragonPhase(List<IWarrior> warriors, List<ArtifactBase> artifacts)
    {
        Dragon dragon = new();
        if (_dragonsDen.DragonsCount < 3)
        {
            return false;
        }
        return dragon.IsVulnerable(warriors, artifacts);
    }
    public void ReGroupPhase()
    {

    }
}
