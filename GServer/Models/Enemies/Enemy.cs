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
    public EnemyType Type { get; private set; }
    public Enemy(EnemyType TypeEnemies)
    {
        type = TypeEnemies;
    }
}