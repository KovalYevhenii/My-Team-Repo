using GServer.Models.Artifacts;
using GServer.Models.Enemies;
using GServer.Models.Сemetery;

namespace GServer.Models.Warriors
{
    public interface IWarrior
    {
        public WarriorType Type { get; }
        public bool Attack(List<Enemy> enemies, Cave cave, ICemetery cemetery);
        public ArtifactBase OpenTreasure();
    }
}
