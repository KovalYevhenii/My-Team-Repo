using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.Models.Artifacts
{
    public class ThieveToolsArtifact : ArtifactBase, IArtifactWarrior
    {
        public ThieveToolsArtifact()
        {
            Name = "Воровские инструменты";
            ArtifactType = ArtifactType.ThieveToolsArtifact;
            Description = "";
            IsCanByUsed = true;
        }
        public Warrior UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);

            return new Thief();
        }
    }
}
