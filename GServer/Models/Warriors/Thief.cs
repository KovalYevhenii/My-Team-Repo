﻿using GServer.Models.Enemies;
namespace GServer.Models.Warriors;
public class Thief : Warrior, IWarrior
{
    public Thief()
    {
        Type = WarriorType.Thief;
    }
    public void Attack(Enemy enemy)
    {
        throw new NotImplementedException();
    }
    public void OpenTreasure()
    { throw new NotImplementedException(); }
}
