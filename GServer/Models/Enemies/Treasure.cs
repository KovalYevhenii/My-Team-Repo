using GServer.Models.Artifacts.Artifact;

namespace GServer.Models.Enemies;
public class Treasure : Enemy,IEnemy 
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
}
