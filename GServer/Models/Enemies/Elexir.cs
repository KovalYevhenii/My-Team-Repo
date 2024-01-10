using GServer.Models.Warriors;
using GServer.Models.Сemetery;

namespace GServer.Models.Enemies
{
    public class Elexir:Enemy
    {
        public Elexir():base(EnemyType.Elixir)
        {
        }
        public void Drink(IWarrior warrior)
        {
            ICemetery cemetery;
            //Где брать воинов если не из кладбища
        }
    }
}
