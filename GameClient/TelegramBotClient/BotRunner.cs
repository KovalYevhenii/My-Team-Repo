using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using TelegramBotClient.Interfaces;
namespace TelegramBotClient;
internal class BotRunner : IBotRunner
{
    private readonly ITelegramBotClient _botClient;
    private readonly ITelegramBotHandler _botHandler;
    private readonly ICallBackRegistrator _registrator;

    public BotRunner(ITelegramBotClient botClient, ITelegramBotHandler botHandler, ICallBackRegistrator callBack)
    {
        _botClient = botClient;
        _botHandler = botHandler;
        _registrator = callBack;
    }
    public async Task RunBotAsync(CancellationToken cancellationToken)
    {
        var me = await _botClient.GetMeAsync();
        Console.WriteLine($"==== {me.FirstName} started====\n");

        _registrator.RegisterCallbacks();

        _botClient.StartReceiving(
        updateHandler: _botHandler.HandleUpdateAsync,
        pollingErrorHandler: _botHandler.HandlePollingErrorAsync,
        receiverOptions: new ReceiverOptions()
        {
            AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
        },
        cancellationToken: cancellationToken
    );
    }
}
