using GServer.Models.Artifacts;
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
        public string id = string.Empty; 
        public WarriorType type { get; protected set; }
    }
}
