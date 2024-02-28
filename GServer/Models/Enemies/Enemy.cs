namespace GServer.Models.Enemies;
public enum EnemyType
{
    Goblin,
    Treasure,
    Skeleton,
    Slime,
    Elixir,
    Dragon
}
 public abstract class Enemy
{
    public string id;
    public EnemyType Type { get; private set; }
    public Enemy(EnemyType TypeEnemies)
    {
        Type = TypeEnemies;
    }
}