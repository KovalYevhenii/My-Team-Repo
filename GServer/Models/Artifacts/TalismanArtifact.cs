using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.Models.Artifacts
{
    public class TalismanArtifact : ArtifactBase,IArtifactWarrior
    {
        public TalismanArtifact()
        {
            Name = "Талисман";
            ArtifactType = ArtifactType.TalismanArtifact;
            Description = "";
            IsCanByUsed = true;
        }
        public Warrior UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);

            return new Cleric();
        }
    }
}
