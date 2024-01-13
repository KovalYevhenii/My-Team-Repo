using GServer.Models.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.Сemetery
{
    public class Cemetery : ICemetery
    {
        private List<IWarrior> warriors = new();

        public void AddWarrior(IWarrior warrior)
        {
            warriors.Add(warrior);
        }

        public IWarrior GetWarrior(IWarrior warrior)
        {
            warrior = warriors.FirstOrDefault(w => w.Type == warrior.Type);
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