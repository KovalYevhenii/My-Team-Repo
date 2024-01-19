using GServer.Models.Artifacts.Artifact;
using GServer.Models.Warriors;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace GServer.Models.Heroes
{
    public class Enchantress : Hero
    {
        public HeroType GetHeroType()
        {
            return type;
        }

        public void ChangeLavel(int _level)
        {
            level = _level;
        }
        public Enchantress(HeroType _type)
        {
            type = _type;
        }

        public void ChangeLAbility()
        {
            throw new NotImplementedException();
        }

        enum eName
        {
            ВОЛШЕБНИЦА,
            ЧАРОДЕЙКА,
        }
    }
}
