using GServer.Models.Enemies;
using GServer.Models.Warriors;

namespace GServer.GameProcess;
public interface ICaveProcess
{
    void MonsterPhase(List<IWarrior> warriors, List<IEnemy> enemies);
}
