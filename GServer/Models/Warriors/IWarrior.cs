using GServer.Models.Enemies;
namespace GServer.Models.Warriors;
public interface IWarrior
{
    public void Attack(IList<IEnemy> enemies);
    public void OpenTreasure();
}
