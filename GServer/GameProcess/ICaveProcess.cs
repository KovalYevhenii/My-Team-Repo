﻿using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.GameProcess;
public interface ICaveProcess
{
    void MonsterPhase(IWarrior warrior, List<Enemy> enemies);
}
