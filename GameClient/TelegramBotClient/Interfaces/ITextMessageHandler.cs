using Telegram.Bot.Types;
namespace TelegramBotClient.Handlers.Interfaces;
internal interface ITextMessageHandler
{
    public Task BotOnTextMessageReceiving(ChatId chatId, string message);
}
