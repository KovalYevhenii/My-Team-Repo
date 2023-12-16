using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Artifact;
using GServer.Models.Warriors;

namespace GServer.Models.Heroes
{
    public abstract class Hero
    {
        public int Lavel { get; set; }
        public int LAbility { get; set; }
        public Enum Name { get; set; }
        public Enum Skill { get; set; }
        public Enum Ability { get; set; }
        public int Scores { get; set; }

        public readonly int ScoresToLavelUp = 5;
        //public List<IArtifact> Inventory { get; set; }
        public List<Artifact> Inventory { get; set; }
        public List<IWarrior> Crew { get; set; }
    }
}
