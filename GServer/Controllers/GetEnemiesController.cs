using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GServer.GameProcess;
using GServer.Models.Enemies;

namespace GServer.Controllers
{
    public class GetEnemiesController
    {
        private EnemiesProcess _enemyProcess;
        public List<IEnemy> GetEnemies()
        {
            return _enemyProcess.GetRandomEnemies();
        }
    }
}