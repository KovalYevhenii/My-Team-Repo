using System;

namespace GServer.Models.Enemies
{
    public interface IEnemy
    {
        public List<Enemy> ThrowDice(int numberOfDice);
        public DiceSide GetRandomDiceSide();

    }
}
