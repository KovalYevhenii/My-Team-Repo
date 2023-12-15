using Telegram.Bot.Types.ReplyMarkups;
namespace TelegramBotClient;
public class GameKeyboard
{
    public ReplyKeyboardMarkup CreateExampleKeyboard()
    {
        var button1 = KeyboardButtonFactory.CreateButton("1");
        var button2 = KeyboardButtonFactory.CreateButton("2");
        var button3 = KeyboardButtonFactory.CreateButton("3");
        var button4 = KeyboardButtonFactory.CreateButton("4");

        var replyKeyboard = new ReplyKeyboardMarkup(new[]
        {
            new[] { button1, button2 },
            new[] { button3, button4 }
        });
        return replyKeyboard;
    }
}