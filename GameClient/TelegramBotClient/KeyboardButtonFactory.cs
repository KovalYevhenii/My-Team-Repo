using Telegram.Bot.Types.ReplyMarkups;
namespace TelegramBotClient;
public class KeyboardButtonFactory
{
    public static KeyboardButton CreateButton(string text)
    {
        return new(text);
    }
}
