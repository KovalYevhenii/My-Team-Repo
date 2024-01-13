using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.Models.Artifacts
{
    public class SwordArtifact : ArtifactBase, IArtifactWarrior
    {
        public SwordArtifact()
        {
            Name = "Разящий меч";
            ArtifactType = ArtifactType.SwordArtifact;
            Description = "";
            IsCanByUsed = true;
        }
        public Warrior UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);

            return new Guard();
        }
    }
}
