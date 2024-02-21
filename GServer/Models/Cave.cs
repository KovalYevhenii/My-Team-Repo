using GServer.Models.Artifacts;
using GServer.Models.Enemies;

namespace GServer.Models
{
    public class Cave
    {
        public int level;
        public List<IEnemy>  Enemies { get; set; }
        public Cave()
        {
            Enemies = new List<IEnemy>();
            level = 0;
        }
        public void LevelUp ()
        {
            ++level;
        }
    }
}
