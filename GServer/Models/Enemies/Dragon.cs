using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Warriors;

namespace GServer.Models.Enemies
{
    public class Dragon : Enemy, IEnemy
    {
        public Dragon() : base(EnemyType.Dragon)
        {
        }
        public bool IsVulnerable(List<IWarrior> warriors, List<ArtifactBase> artifacts)
        {
            int itemsToBeat = 3;
            var warriorsArtifacts = artifacts.OfType<IArtifactWarrior>().ToList();
            return warriors.Count + warriorsArtifacts.Count == itemsToBeat;
        }
        
    }
}
