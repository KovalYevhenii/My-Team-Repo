using GServer.GameProcess;
using GServer.Models.Heroes;

namespace GServer.Controllers
{
    public class GetHeroController
    {
        private HeroProcess _heroProcess;
        public string GetHero()
        {
            _heroProcess = new HeroProcess();
            Hero _hero = _heroProcess.GetRandomHero();
            return _hero;
        }
         
    }
}
