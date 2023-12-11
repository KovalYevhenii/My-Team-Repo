using GServer.Models.Artifacts;

namespace GServer.Models.Enemies;
public class Treasure : Enemy
{
    public Treasure()
    {
        Type = EnemyType.Treasure;
    }
    public IArtifact Artifact { get; set; }
    public IArtifact Open()
    {
        return Artifact;
    }
}
