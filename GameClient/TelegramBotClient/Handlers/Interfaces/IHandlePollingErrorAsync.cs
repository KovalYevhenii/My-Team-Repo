using Telegram.Bot;

namespace TelegramBotClient.Handlers.Interfaces
{
    internal interface IHandlePollingErrorAsync
    {
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken);
    }
}