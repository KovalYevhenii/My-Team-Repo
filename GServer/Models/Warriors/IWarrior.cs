using GServer.Models.Enemies;

namespace GServer.Models.Warriors
{
    public interface IWarrior
    {
        public WarriorType GetType();
        public bool Attack(Enemy enemy);
    }
}
