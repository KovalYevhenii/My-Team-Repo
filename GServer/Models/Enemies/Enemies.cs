namespace GServer.Models.Enemies
{
    public class Enemies
    {
        public Dictionary<Enum typeEnemy, IEnemy> Elist = new Dictionary<Enum, IEnemy>()
        {
            'typeEnemy.goblin':new Goblin();
        }
    }
}
