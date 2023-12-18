namespace GServer.Models.Warriors
{
    public enum WarriorType
    {
        Cleric,
        Guard,
        Mage,
        Scroll,
        Knight,
        Thief
    }
    public abstract class Warrior
    {
        public WarriorType Type { get; set; }
    }
}
