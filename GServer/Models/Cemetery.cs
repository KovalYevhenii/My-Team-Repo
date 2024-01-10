using GServer.Models.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models
{
    public class Сemetery
    {
        private List<Warrior> warriors;

        public Сemetery()
        {
            warriors = new List<Warrior>();
        }

        public void Addwarrior(Warrior warrior)
        {
            warriors.Add(warrior);
        }

        public Warrior? Getwarrior(WarriorType typeWarrior)
        {
            Warrior? _warrior = warriors.FirstOrDefault(w => w.type == typeWarrior);
            
            return _warrior;
        }
    }
}