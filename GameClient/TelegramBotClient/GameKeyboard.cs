using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;
using TelegramBotClient.Models.Warriors;

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
        string singlePlayerGuid = _callbackManager.RegisterCallback((botClient, chatId) =>
        StartingGameKeyboardAsync()(botClient, chatId));

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
        string startingGame = _callbackManager.RegisterCallback((botClient, chatId) =>
        ChooseHeroButtonsAsync()(botClient, chatId));

        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("Yes",startingGame),
                    InlineKeyboardButton.WithCallbackData("No"),
                }
            });
            await botClient.SendTextMessageAsync(chatId,
                "Начать игру?", replyMarkup: keyboard);
        };
    }
    public Func<ITelegramBotClient, ChatId, Task> ChooseHeroButtonsAsync()
    {
        string ChooseHero = _callbackManager.RegisterCallback((botClient, chatId) =>
        ThrowDiceButtonsAsync()(botClient, chatId));

        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
            new []
            {
                InlineKeyboardButton.WithCallbackData("взять героя",ChooseHero),
                InlineKeyboardButton.WithCallbackData("Попробовать еще раз"),
            }
            });
            await botClient.SendTextMessageAsync(chatId,
                "Выбрать данного героя?", replyMarkup: keyboard);
        };
    }
    public Func<ITelegramBotClient, ChatId, Task> ThrowDiceButtonsAsync()
    {
        string warriorsDice = _callbackManager.RegisterCallback((botClient, chatId) =>
        WarriorsDiceButtonsAsync()(botClient, chatId));
        return async (botClient, chatId) =>
        {
            var keyboard = new InlineKeyboardMarkup(new[]
            {
            new []
            {
                InlineKeyboardButton.WithCallbackData("Yes",warriorsDice),
                InlineKeyboardButton.WithCallbackData("No"),
            }
            });
            await botClient.SendTextMessageAsync(chatId,
                "бросить кубики", replyMarkup: keyboard);
        };
    }
    public Func<ITelegramBotClient, ChatId, Task> WarriorsDiceButtonsAsync()
    {
        return async (botClient, chatId) =>
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
               $"Вы получили кубики Воинов\n{new Warrior { Type = WarriorType.Guard }.Name}" +
               $", {new Warrior { Type = WarriorType.Thief }.Name}, " +
               $", {new Warrior { Type = WarriorType.Thief }.Name}, " +
               $", {new Warrior { Type = WarriorType.Scroll }.Name}, " +
               $", {new Warrior { Type = WarriorType.Thief }.Name}, " +
               $", {new Warrior { Type = WarriorType.Paladin }.Name}, " +
               $"{new Warrior { Type = WarriorType.Cleric }.Name}", replyMarkup: keyboard);
        };
    }
}