using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;

namespace TelegramBotClient;
public class GameKeyboard : IGameKeyboard
{
    private readonly ICallbackManager _callbackManager;

    public GameKeyboard(ICallbackManager callbackManager)
    {
        _callbackManager = callbackManager;
    }
    public Func<ITelegramBotClient, ChatId, Task> VersionKeyboardAsync()
    {
        string singlePlayerGuid = _callbackManager.RegisterCallback((botClient, chatId) => StartingGameKeyboardAsync()(botClient, chatId));

        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("Однопользовательская", singlePlayerGuid),
                    InlineKeyboardButton.WithCallbackData("Многопользовательская"),
                }
            });

            await botClient.SendTextMessageAsync(chatId,
                "Выбор версии", replyMarkup: keyboard);
        };
    }
    public Func<ITelegramBotClient, ChatId, Task> StartingGameKeyboardAsync()
    {
        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("Yes"),
                    InlineKeyboardButton.WithCallbackData("No"),
                }
            });

            await botClient.SendTextMessageAsync(chatId,
                "Начать игру?", replyMarkup: keyboard);
        };
    }

    public async Task ChooseHeroButtonsAsync(ITelegramBotClient botClient, ChatId chatId)
    {
        var keyboard = new InlineKeyboardMarkup(new[]
       {
            new []
            {
                InlineKeyboardButton.WithCallbackData("взять героя"),
                InlineKeyboardButton.WithCallbackData("Попробовать еще раз"),
            }
        });
        await botClient.SendTextMessageAsync(chatId, "Выбрать данного героя?", replyMarkup: keyboard);
    }
    public async Task ThrowDiceButtonsAsync(ITelegramBotClient botClient, ChatId chatId)
    {
        var keyboard = new InlineKeyboardMarkup(new[]
         {
            new []
            {
                InlineKeyboardButton.WithCallbackData("Yes1"),
                InlineKeyboardButton.WithCallbackData("No1"),
            }
        });

        await botClient.SendTextMessageAsync(chatId,
            "бросить кубики", replyMarkup: keyboard);
    }
    public async Task WarriorsDiceButtonsAsync(ITelegramBotClient botClient, ChatId chatId)
    {
        var keyboard = new InlineKeyboardMarkup(new[]
         {
            new []
            {
                InlineKeyboardButton.WithCallbackData("Принять"),
                InlineKeyboardButton.WithCallbackData("Перебросить"),
            }
        });

        await botClient.SendTextMessageAsync(chatId,
            "Вы получили кубики Воинов", replyMarkup: keyboard);
    }
}