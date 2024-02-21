using Telegram.Bot.Types;
using Telegram.Bot;
using TelegramBotClient.Handlers.Interfaces;

namespace TelegramBotClient.Handlers;
public class TextMessageHandler : ITextMessageHandler
{
    private readonly ITelegramBotClient _botClient;
    private readonly IGameKeyboard _startMenuKeyboard;
    public TextMessageHandler(ITelegramBotClient botClient, IGameKeyboard startMenuKeyboard)
    {
        _botClient = botClient;
        _startMenuKeyboard = startMenuKeyboard;
    }
    public async Task BotOnTextMessageReceiving(ChatId chatId, string message)
    {
        switch (message)
        {
            case "/start":
                await _startMenuKeyboard.VersionKeyboard(_botClient, chatId);

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
