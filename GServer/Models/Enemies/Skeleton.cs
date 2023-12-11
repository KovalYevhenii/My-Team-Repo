namespace GServer.Models.Enemies
{
    public class Skeleton : Enemy, IEnemy
    {
        public Skeleton()
        {
            Type = EnemyType.Skeleton;   
        }
    }
}
