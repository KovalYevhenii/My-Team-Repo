using GServer.Models.Enemies;
namespace GServer.Models.Warriors;
public interface IWarrior
{
    void Attack(IList<IEnemy> enemys);
    void OpenTreasure();
}
