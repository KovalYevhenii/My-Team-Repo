using GServer.Models.Artifacts;
using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public interface IWarrior
    {
        public bool Attack(Enemy enemy);
        public ArtifactBase OpenTreasure();
    }
}
