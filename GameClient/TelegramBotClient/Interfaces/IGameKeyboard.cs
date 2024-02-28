using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotClient.Handlers.Interfaces
{
    public interface IGameKeyboard
    {
        public Func<ITelegramBotClient, ChatId, Task> VersionKeyboardAsync();
        public Func<ITelegramBotClient, ChatId, Task> StartingGameKeyboardAsync();
        Task ChooseHeroButtonsAsync(ITelegramBotClient botClient, ChatId chatId);
        Task ThrowDiceButtonsAsync(ITelegramBotClient botClient, ChatId chatId);
        Task WarriorsDiceButtonsAsync(ITelegramBotClient botClient, ChatId chatId);
    }
}
