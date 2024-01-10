using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Artifact;
using GServer.Models.Warriors;

namespace GServer.Models.Heroes
{
    abstract public class Hero
    {
        protected HeroType type;
        protected int level;
        protected int scores;
        public readonly int scoresToLavelUp = 5;
        public List<Artifact> Inventory;
        public List<IWarrior> Crew;
    }
    public enum HeroType
    {
        ENCHANTRESS,
        SOLDEROFFORTUNE,
        KNIGHT,
        BARD,
        MAG,
        NECROMANCER,
        CRUSADER,
        GOBLIN
    }
}
