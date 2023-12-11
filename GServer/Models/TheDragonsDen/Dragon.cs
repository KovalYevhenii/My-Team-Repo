using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.TheDragonsDen
{
    public class Dragon : ICreature
    {
        public CreatureType Type { get; set; }
        public string Name { get; set; }
    }
}
