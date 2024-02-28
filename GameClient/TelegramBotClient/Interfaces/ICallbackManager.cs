using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBotClient.Interfaces;
public interface ICallbackManager
{
    public string RegisterCallback(Action<ITelegramBotClient, ChatId> callback);
    public void UnregisterCallback(string guid);
    public bool TryGetCallback(string guid, out Action<ITelegramBotClient, ChatId> callback);
}
