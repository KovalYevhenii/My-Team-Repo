using GServer.Models.Enemies;

namespace GServer.Models.Warriors;
public class Guard : Warrior, IWarrior
{
    public Guard()
    {
        Type = WarriorType.Guard;
    }
    public override bool Attack(Enemy enemy)
    {
        return true;
    }
   
}
