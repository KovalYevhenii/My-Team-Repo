using GServer.Models.Artifacts.Artifact;
using GServer.Models.Warriors;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace GServer.Models.Heroes
{
    public class Enchantress : Hero, IHero
    {
        public Enchantress()
        {
            Lavel = 0;
            Name = eName.ВОЛШЕБНИЦА;
            Skill = eName.ВОЛШЕБНИЦА;
            Ability = eName.ВОЛШЕБНИЦА;
            Scores = 0;
            //Inventory = new List<IArtifact>();
            Inventory = new List<Artifact>();
            Crew = new List<IWarrior>();
        }

        public void ChangeLavel()
        {
            if (Scores >= ScoresToLavelUp)
            {
                Lavel = 1;
                Name = eName.ЧАРОДЕЙКА;
                Skill = eName.ЧАРОДЕЙКА;
                Ability = eName.ЧАРОДЕЙКА;
            }
        }

        public void SkillAction()
        {
            throw new NotImplementedException();
        }

        public void AbilityAction()
        {
            throw new NotImplementedException();
        }

        public void ChangeLAbility()
        {
            throw new NotImplementedException();
        }

        enum eName
        {
            NOT,
            ВОЛШЕБНИЦА,
            ЧАРОДЕЙКА,
        }
    }
}
