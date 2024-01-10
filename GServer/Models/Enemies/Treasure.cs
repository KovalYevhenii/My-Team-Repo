using GServer.Models.Artifacts.Artifact;
using GServer.Models.Enemies.Interfaces;

namespace GServer.Models.Enemies;
public class Treasure : Enemy, ITresure 
{
    public Treasure(EnemyType TypeEnemies)
    {
        type = EnemyType.Treasure;
    }
    public Artifact Artifact { get; set; }
    public Artifact Open()
    {
        return Artifact;
    }

    public Artifact OpenTreasure()
    {
        return Open();
    }
}
