using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;

namespace TelegramBotClient.Handlers;
public class CallBackHandler : ICallbackHandler
{
    private readonly ITelegramBotClient _botClient;
    private readonly ICallbackManager _callbackManager;
    public CallBackHandler(ITelegramBotClient botClient, ICallbackManager callbackManager)
    {
        _botClient = botClient;
        _callbackManager = callbackManager;
    }
    private readonly Dictionary<string, bool> _buttonPressedFlag = new();
    public async Task BotOnCallbackDataReceiving(CallbackQuery callbackQuery, ChatId chatId)
    {
        if (_buttonPressedFlag.ContainsKey(callbackQuery.Data) && _buttonPressedFlag[callbackQuery.Data])
        {
            return;
        }
        if (_callbackManager.TryGetCallback(callbackQuery.Data, out var callback))
        {
             callback(_botClient, chatId);
        }
    }
}
