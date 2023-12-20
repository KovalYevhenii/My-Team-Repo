using GServer.Models.Artifacts;
using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public enum WarriorType
    {
        Cleric,
        Guard,
        Mage,
        Scroll,
        Knight,
        Thief
    }
    public abstract class Warrior: IWarrior
    {
        public WarriorType Type { get; protected set; }

        public abstract bool Attack(Enemy enemy);
        public abstract ArtifactBase OpenTreasure(List<ArtifactBase> artifacts);

    }
}
