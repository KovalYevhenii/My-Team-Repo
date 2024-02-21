using GServer.Models.Enemies;
namespace GServer.Models.TheDragonsDen
{
    public class TheDragonsDen : IDragonsDen
    {
        public List<IEnemy> DragonsList { get; set; }
        public int DragonsCount
        {
            get { return DragonsList.Count; }
        }
        public TheDragonsDen()
        {
            DragonsList = new List<IEnemy>();
        }
        public void AddDragon<T>(T dragon)
            where T : Dragon, IEnemy
        {
            DragonsList.Add(dragon);
        }
    }
}
