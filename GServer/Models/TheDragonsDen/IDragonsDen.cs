using GServer.Models.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.TheDragonsDen
{
    public interface IDragonsDen
    {
        List<IEnemy> DragonsList { get; set; }
        int DragonsCount { get; }
        public void AddDragon<T>(T dragon)
             where T : Dragon, IEnemy;
    }
}
