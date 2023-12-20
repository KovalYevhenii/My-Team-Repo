using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Artifact;
using GServer.Models.Artifacts.Helpers;

namespace GServer.Models.Enemies;
public class Treasure : Enemy,IEnemy 
{
    public Treasure():base(EnemyType.Treasure)
    {
        Artifact = HelperArtifact.GetArtifact("Take random Artifact");
    }
   public ArtifactBase Artifact { get; }
    public ArtifactBase Open()
    {
        return Artifact;
    }
}
