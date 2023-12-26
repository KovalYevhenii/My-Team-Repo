using GServer.Models.Artifacts;
using GServer.Models.Artifacts.ArtifactStorage;
using GServer.Models.Enemies;
using GServer.Models.Сemetery;

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

        public abstract bool Attack(List<Enemy> enemies,Cave cave, ICemetery cemetery);
        public virtual ArtifactBase OpenTreasure()
        {
            return ArtifactStorage.GetArtifact();
        }
    }
}
