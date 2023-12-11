using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.Creature
{
    public interface ICreature
    {
        CreatureType Type { get; set; }
        string Name { get; set; }
    }
}
