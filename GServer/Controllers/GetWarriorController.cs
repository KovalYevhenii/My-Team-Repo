using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GServer.GameProcess;
using GServer.Models.Warriors;

namespace GServer.Controllers
{
    public class GetWarriorController
    {
        private WarriorsProcess _warriorProcess;

        public IWarrior GetWarrior()
        {
            return _warriorProcess.GetRandomWarrior();
        }
    }
}
