namespace GServer.Models.Enemies
{
    public class Slime : Enemy, IEnemy
    {
        public Slime()
        {
            Type = EnemyType.Slime;
        }
    }
}
