using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.Сemetery
{
    public class Cemetery : ICametry
    {
        private List<Warrior> warriors = new List<Warrior>();

        public void AddWarrior(Warrior warrior)
        {
            warriors.Add(warrior);
        }

        public Warrior GetWarrior(string type)
        {
            Warrior warrior = warriors.FirstOrDefault(w => w.Type == type);
            if (warrior != null)
            {
                warriors.Remove(warrior);
                return warrior;
            }
            else
            {
                return null;
            }
        }
    }
}