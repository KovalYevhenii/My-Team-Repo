namespace GServer.Models.Enemies
{
    public class Dragon : Enemy, IEnemy
    {
        public Dragon(): base(EnemyType.Dragon)
        {
        }
        public void WakeUp()
        {
            throw new NotImplementedException();
        }
    }
}
