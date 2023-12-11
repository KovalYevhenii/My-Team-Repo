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
    public EnemyType Type { get; set; }
}