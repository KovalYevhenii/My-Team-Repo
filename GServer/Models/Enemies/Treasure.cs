using GServer.Models.Artifacts;
using GServer.Models.Artifacts.ArtifactStorage;

namespace GServer.Models.Enemies
{
    public class Treasure : Enemy
    {
        public Treasure() : base(EnemyType.Treasure)
        {
            Artifact = ArtifactStorage.GetArtifact();
        }
        public ArtifactBase Artifact { get; }
    }
}
   