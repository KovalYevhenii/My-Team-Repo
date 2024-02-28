using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;

namespace TelegramBotClient.Handlers;
public class CallbackRegistrator: ICallBackRegistrator
{
    private readonly ICallbackManager _callbackManager;
    private readonly IGameKeyboard _gameKeyboard;

    public CallbackRegistrator( ICallbackManager callbackManager, IGameKeyboard gameKeyboard)
    {
        _callbackManager = callbackManager;
        _gameKeyboard = gameKeyboard;
    }
    public void RegisterCallbacks()
    {
        string singlePlayerGuid = _callbackManager.RegisterCallback((botClient, chatId) => _gameKeyboard.VersionKeyboardAsync());
        string startGameGuid = _callbackManager.RegisterCallback((botClient, chatId) => _gameKeyboard.StartingGameKeyboardAsync());
    }
}
