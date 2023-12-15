using Telegram.Bot.Types;
using Telegram.Bot;
using TelegramBotClient.Handlers.Interfaces;

namespace TelegramBotClient.Handlers;
public class TextMessageHandler:ITextMessageHandler 
{
    private readonly ITelegramBotClient _botClient;
    private readonly GameKeyboard _startMenuKeyboard;
    public TextMessageHandler(ITelegramBotClient botClient, GameKeyboard startMenuKeyboard)
    {
        _botClient = botClient;
        _startMenuKeyboard = startMenuKeyboard;
    }
    public async Task BotOnTextMessageReceiving(ChatId chatId, string message)
    {
        switch (message)
        {
            case "/start":
               var replyKeyboard =  _startMenuKeyboard.CreateExampleKeyboard();
                await _botClient.SendTextMessageAsync(chatId, "Choose an Option", replyMarkup: replyKeyboard);
                break;
            case "Action1":
                await _botClient.SendTextMessageAsync(chatId, "Режим для одного");
                break;
            case "/command1":
                Console.WriteLine("Правила");
                break;
        }
    }
}
