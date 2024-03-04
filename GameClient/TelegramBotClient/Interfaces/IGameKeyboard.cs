using Telegram.Bot.Types;
using Telegram.Bot;
namespace TelegramBotClient.Handlers.Interfaces;
public interface IGameKeyboard
{
    public Func<ITelegramBotClient, ChatId, Task> VersionKeyboardAsync();
    public Func<ITelegramBotClient, ChatId, Task> StartingGameKeyboardAsync();
    public Func<ITelegramBotClient, ChatId, Task> ChooseHeroButtonsAsync();
    public Func<ITelegramBotClient, ChatId, Task> ThrowDiceButtonsAsync();
    public Func<ITelegramBotClient, ChatId, Task> WarriorsDiceButtonsAsync();
}
