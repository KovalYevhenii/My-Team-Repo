namespace GServer.Models.Enemies;
public enum DiceSide
{
    Goblin,
    Treasure,
    Skeleton,
    Slime,
    Elixir,
    Dragon
}
public class Enemy : IEnemy
{
    public DiceSide Type { get; set; }
    private static readonly Random _random = new();
    public Enemy(DiceSide type)
    {
        Type = type;
    }
    public List<Enemy> ThrowDice(int numberOfDice)
    {
        var enemies = new List<Enemy>();
        for (int i = 0; i < numberOfDice; i++)
        {
            DiceSide diceResult = GetRandomDiceSide();
            if (IsDragon(diceResult))
            {
                //SendDragonToLaird()
            }
            else
            {
                var enemy = new Enemy(diceResult);
                enemies.Add(enemy);
            }
        }
        return enemies;
    }
    public DiceSide GetRandomDiceSide()
    {
        int maxDiceSidex = Enum.GetValues(typeof(DiceSide)).Length;
        return (DiceSide)_random.Next(0, maxDiceSidex);
    }
    private bool IsDragon(DiceSide result) =>
        result == DiceSide.Dragon;
}