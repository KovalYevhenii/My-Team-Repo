namespace GServer.Models.Enemies
{
    public class Goblin:Enemy,IEnemy
    {
        public Goblin():base(EnemyType.Goblin)
        {
        }
    }
}
