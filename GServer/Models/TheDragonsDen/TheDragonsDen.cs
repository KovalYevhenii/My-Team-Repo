using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GServer.Models.TheDragonsDen
{
    public class TheDragonsDen : IDragonsDen
    {
        private List<Dragon> dragons = new List<Dragon>();

        public void AddDragon(Dragon dragon)
        {
            dragons.Add(dragon);
            if (dragons.Count >= 3)
            {
                StartBattle();
            }
        }

        private void StartBattle()
        {
            Console.WriteLine("Дракон проснулся!");
        }

        void IDragonsDen.StartBattle()
        {
            throw new NotImplementedException();
        }
    }
}
