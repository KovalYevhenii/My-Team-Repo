using GServer.Models.Enemies;
namespace GServer.Models.Warriors;
public interface IWarrior
{
    public void Attack(Enemy enemy);
    public void OpenTreasure();
}
