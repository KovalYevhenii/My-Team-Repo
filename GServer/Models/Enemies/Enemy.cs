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
public abstract class Enemy: IEnemy
{
    public EnemyType Type { get; set; }
}