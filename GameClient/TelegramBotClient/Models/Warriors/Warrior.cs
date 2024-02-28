namespace TelegramBotClient.Models.Warriors;
public enum WarriorType
{
    Mage = 1,
    Paladin,
    Cleric,
    Guard,
    Thief,
    Scroll
}
public class Warrior
{
    public WarriorType Type { get; set; }
    public string Name
    {
        get
        {
            switch (Type)
            {
                case WarriorType.Mage:
                    return "🔮 Mage";
                case WarriorType.Paladin:
                    return "⚔️ Paladin";
                case WarriorType.Cleric:
                    return "🏹 Cleric";
                case WarriorType.Guard:
                    return "🗡️ Guard";
                case WarriorType.Thief:
                    return "🥷 Thief";
                    case WarriorType.Scroll:
                    return "📜 Scroll";
                    default:
                    throw new NotImplementedException();
            }
        }
    }
}
