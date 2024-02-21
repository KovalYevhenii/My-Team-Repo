using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotClient.Handlers.Interfaces;
namespace TelegramBotClient;
public class GameKeyboard: IGameKeyboard
{
    public async Task VersionKeyboard(ITelegramBotClient botClient, ChatId chatId)
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
    }
    public async Task StartingGameKeyboard(ITelegramBotClient botClient, ChatId chatId)
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
    }
}