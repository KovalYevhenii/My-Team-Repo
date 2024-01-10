namespace GServer.Models.Warriors
{
    public enum WarriorType
    {
        CLERIC,
        GUARD,
        MAGE,
        SCROLL,
        KNIGHT,
        THEIF
    }
    public abstract class Warrior
    {
        public WarriorType type { get; set; }
    }
}
