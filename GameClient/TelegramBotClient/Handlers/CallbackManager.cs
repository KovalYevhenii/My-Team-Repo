using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotClient.Interfaces;
namespace TelegramBotClient.Handlers;
public class CallbackManager: ICallbackManager
{
    private readonly Dictionary<string, Action<ITelegramBotClient, ChatId>> _callbackHandlers = new();

    public string RegisterCallback(Action<ITelegramBotClient, ChatId> callback)
    {
        string guid = Guid.NewGuid().ToString();
        _callbackHandlers[guid] = callback;
        return guid;
    }
    public void UnregisterCallback(string guid)
    {
        _callbackHandlers.Remove(guid);
    }
    public bool TryGetCallback(string guid, out Action<ITelegramBotClient, ChatId> callback)
    {
        try
        {
            return _callbackHandlers.TryGetValue(guid, out callback);
        }
        catch (NullReferenceException)
        {
            throw;
        }
    }
}
