using GServer.Models.Artifacts;
using GServer.Models.Enemies;

namespace GServer.Models
{
    public class Cave
    {
        public int Level;
        public List<IEnemy>  Enemies { get; set; }
        public Cave()
        {
            Enemies = new List<IEnemy>();
            Level = 0;
        }
    }
}
