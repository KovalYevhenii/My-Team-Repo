using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.GameProcess
{
    public class EnemiesProcess
    {
        public IEnemy GetRandomEnemy()
        {
            return new Skeleton();
        }
    }
}