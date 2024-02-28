using Telegram.Bot;

namespace TelegramBotClient.Interfaces
{
    internal interface IHandlePollingErrorAsync
    {
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken);
    }
}