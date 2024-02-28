using GServer.Models.Warriors;

namespace GServer.Models
{
    public class Cemetery
    {
        public List<Warrior> warriors;
        public Cemetery() {
            warriors = new List<Warrior>();
        }
    }
}