using Telegram.Bot.Types.ReplyMarkups;
namespace TelegramBotClient;
public class KeyboardButtonFactory
{
    public async Task<KeyboardButton> CreateButton(string text)
    {
        return new(text);
    }
}
