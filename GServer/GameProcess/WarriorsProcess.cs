using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.GameProcess
{
    public class WarriorsProcess
    {
        public IWarrior GetRandomWarrior()
        {
            return new Guard();
        }
    }
}