using GServer.Models.Artifacts;
using GServer.Models.Artifacts.Artifact;

namespace GServer.Models.Enemies;
public class Treasure : Enemy
{
    public Treasure()
    {
        Type = EnemyType.Treasure;
    }
    public Artifact Artifact { get; set; }
    public Artifact Open()
    {
        return Artifact;
    }



    //public IArtifact Artifact { get; set; }
    //public IArtifact Open()
    //{
    //    return Artifact;
    //}
}
