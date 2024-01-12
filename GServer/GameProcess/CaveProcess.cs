﻿using GServer.Models;
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
        bool isHeroSkillRequested = false;
        bool isHeroAbilityRequested = false;
        if (warrior.Attack(enemies, _cave, _cemetery))
        {
            _cemetery.AddWarrior(warrior);
            _crew.Remove(warrior);
        }
        if (warrior.Type == WarriorType.Scroll)
        {
            var (newWarriors, newEnemies) = ((Scroll)warrior).Activate(_crew, _cave.Enemies);
            _crew = newWarriors;
            _cave.Enemies = newEnemies;
        }
        if (isHeroSkillRequested)
        {
            _hero.SkillAction();  // проверять по навыку героя
        }
        if(isHeroAbilityRequested)
        {
            _hero.AbilityAction();
        }

        //Or use Hero ability
    }
    public void EarningPhase(IWarrior warrior, List<Enemy> enemies)
    {
        Elexir elexir = new();
        if (warrior.Type == WarriorType.Thief || warrior.Type == WarriorType.Guard)
        {
            foreach (var enemy in enemies.Where(e => e.Type == EnemyType.Treasure))
            {
                var resievedArtifact = warrior.OpenTreasure();
                //присвоить артефакты герою сумка?
            }
        }
        else if(warrior.Type == WarriorType.Cleric|| warrior.Type == WarriorType.Knight)
        {
            var treasure = enemies.FirstOrDefault(e => e.Type == EnemyType.Treasure);
            if (treasure != null)
            {
                var resievedArtifact = warrior.OpenTreasure();
            }
        }
        if(elexir.CanReturnWarriors(warrior, _cemetery))
        {
            _cemetery.AddWarrior(warrior);
            _crew.Remove(warrior);
            var elexirs = enemies.Where(e => e.Type == EnemyType.Elixir).ToList();
            foreach(var e in elexirs)
            {
                _cemetery.GetWarrior(warrior);
                _crew.Add(warrior);
            }
        } 
    }
    public void DragonPhase(IDragonsDen dragonsDen)
    {

    }
    public void ReGroupPhase()
    {
    }

}
