using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotClient.Handlers.Interfaces
{
    public interface IGameKeyboard
    {
        public Task VersionKeyboard(ITelegramBotClient botClient, ChatId chatId);
        public Task StartingGameKeyboard(ITelegramBotClient botClient, ChatId chatId);
    }
}
