using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;

namespace TelegramBotClient.Handlers;
public class CallBackHandler : ICallbackHandler
{
    private readonly ITelegramBotClient _botClient;
    private readonly IGameKeyboard _keyboardWithCallback;
    private readonly ICallbackManager _callbackManager;
    public CallBackHandler(ITelegramBotClient botClient, IGameKeyboard gameKeyboard, ICallbackManager callbackManager)
    {
        _botClient = botClient;
        _keyboardWithCallback = gameKeyboard;
        _callbackManager = callbackManager;
    }
    private readonly Dictionary<string, bool> _buttonPressedFlag = new();
    public async Task BotOnCallbackDataReceiving(CallbackQuery callbackQuery, ChatId chatId)
    {
        //if (_buttonPressedFlag.ContainsKey(callbackQuery.Data) && _buttonPressedFlag[callbackQuery.Data])
        //{
        //    return;
        //}
        //if (_callbackManager.TryGetCallback(callbackQuery.Data, out var callback))
        //{
        //   callback(_botClient, chatId);
        //}
        switch (callbackQuery.Data)
        {

            case "Однопользовательская":
                _buttonPressedFlag[callbackQuery.Data] = true;
                await _keyboardWithCallback.StartingGameKeyboardAsync(_botClient, chatId);
                break;
            case "Многопользовательская":
                await _keyboardWithCallback.StartingGameKeyboardAsync(_botClient, chatId);
                break;
            case "Yes":
                await _keyboardWithCallback.ChooseHeroButtonsAsync(_botClient, chatId);
                break;
            case "взять героя":
                await _keyboardWithCallback.ThrowDiceButtonsAsync(_botClient, chatId);
                break;
            case "Yes1":
                await _keyboardWithCallback.WarriorsDiceButtonsAsync(_botClient, chatId);
                var warriors = new[] { "🔮 Mage", "⚔️ Paladin", "🥷 Thief", "🏹 kliric", "🗡️ Guard" };
                var buttons = warriors.Select(w => new KeyboardButton(w)).ToArray();
                var keyboard = new ReplyKeyboardMarkup(buttons);
                await _botClient.SendTextMessageAsync(chatId, "Choose a warrior:", replyMarkup: keyboard);
                break;
            case "No1":
                break;
            case "No":
                // handle game start cancellation
                break;
            default:
                throw new NotImplementedException();
        }
    }
}
