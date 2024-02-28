using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotClient.Handlers.Interfaces;

namespace TelegramBotClient;
public class GameKeyboard : IGameKeyboard
{
    public Func<ITelegramBotClient, ChatId, Task> VersionKeyboardAsync()
    {
        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
            new []
            {
                InlineKeyboardButton.WithCallbackData("Однопользовательская"),
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