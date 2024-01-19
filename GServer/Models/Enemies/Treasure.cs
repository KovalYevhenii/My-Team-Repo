using GServer.Models.Artifacts;
using GServer.Models.Artifacts.ArtifactStorage;

namespace GServer.Models.Enemies;
    public class Treasure : Enemy, IEnemy
    {
        public Treasure() : base(EnemyType.Treasure)
        {
            Artifact = ArtifactStorage.GetArtifact();
        }
        public ArtifactBase Artifact { get; }
        public ArtifactBase Open()
        {
            return Artifact;
        }
    }

