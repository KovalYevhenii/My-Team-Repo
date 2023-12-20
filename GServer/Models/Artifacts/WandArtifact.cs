using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.Models.Artifacts
{
    public class WandArtifact : ArtifactBase, IArtifactWarrior
    {
        public WandArtifact()
        {
            Name = "Жезл силы";
            ArtifactType = ArtifactType.WandArtifact;
            Description = "";
            IsCanByUsed = true;
        }
        public Warrior UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);

            return new Mage();   
        }
    }
}
