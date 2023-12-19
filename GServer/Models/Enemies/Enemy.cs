﻿namespace GServer.Models.Enemies;
public enum EnemyType
{
    Goblin,
    Treasure,
    Skeleton,
    Slime,
    Elixir,
    Dragon
}
public class Enemy: IEnemy
{
    public EnemyType Type { get; set; }
    public Enemy(EnemyType TypeEnemies)
    {
        Type = TypeEnemies;
    }
}