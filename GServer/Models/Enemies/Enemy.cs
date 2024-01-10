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
abstract public class Enemy
{
    public EnemyType type { get; set; }
    public Enemy(EnemyType TypeEnemies)
    {
        type = TypeEnemies;
    }
}