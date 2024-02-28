namespace TelegramBotClient.Interfaces;
internal interface IBotRunner
{
    public Task RunBotAsync(CancellationToken cancellationToken);
}
