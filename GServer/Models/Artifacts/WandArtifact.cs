using GServer.Models.Artifacts.Interfaces;
using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.Models.Artifacts
{
    public class WandArtifact : ArtifactBase, IArtifactWarrior
    {
        public Warrior UseArtifact()
        {
            return new Mage();   
        }
    }
}
