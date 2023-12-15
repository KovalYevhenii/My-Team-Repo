namespace TelegramBotClient.Handlers.Interfaces;
internal interface IBotRunner
{
    public Task RunBotAsync(CancellationToken cancellationToken);
}
