using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.Сemetery
{
    public interface ICemetery
    {
        void AddWarrior(Warrior warrior);
        Warrior GetWarrior(string name);

    }
}