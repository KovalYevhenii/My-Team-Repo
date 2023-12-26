using GServer.Models.Enemies;
using GServer.Models.Сemetery;

namespace GServer.Models.Warriors;
public class Scroll : Warrior, IWarrior
{
    public Scroll()
    {
        Type = WarriorType.Scroll;
    }

    public override bool Attack(List<Enemy> enemies, Cave cave, ICemetery cemetery)
    {
        return false;
    }
}
