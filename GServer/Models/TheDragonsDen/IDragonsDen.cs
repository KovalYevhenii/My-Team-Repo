using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.TheDragonsDen
{
    public interface IDragonsDen
    {
        void AddDragon(Dragon dragon);
        void StartBattle();
    }
}
