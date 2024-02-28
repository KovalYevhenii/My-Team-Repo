using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Artifact;
using GServer.Models.Warriors;

namespace GServer.Models.Heroes
{
    public abstract class Hero
    {
        public HeroType type;
        public string id  = string.Empty;
        public int level { get; set; } = 0;
        public int scores { get; set; } = 0;
        public List<Warrior> warrior { get; set; } = new List<Warrior>();
        public readonly int scoresToLavelUp = 5;
    }
    public enum HeroType
    {
        ENCHANTRESS,
        SOLDEROFFORTUNE,
        KNIGHT,
        BARD,
        MAGE,
        NECROMANCER,
        CRUSADER,
        GOBLIN
    }
}
