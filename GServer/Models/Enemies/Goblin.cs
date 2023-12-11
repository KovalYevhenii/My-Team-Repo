namespace GServer.Models.Enemies
{
    public class Goblin:Enemy,IEnemy
    {
        public Goblin()
        {
            Type = EnemyType.Goblin;
        }
    }
}
