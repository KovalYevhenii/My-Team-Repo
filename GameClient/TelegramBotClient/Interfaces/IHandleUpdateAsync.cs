using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotClient.Interfaces
{
    internal interface IHandleUpdateAsync
    {
        public Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken);
    }
}