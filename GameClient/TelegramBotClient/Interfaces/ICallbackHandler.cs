
using Telegram.Bot.Types;

namespace TelegramBotClient.Handlers.Interfaces
{
    public interface ICallbackHandler
    {
        public Task BotOnCallbackDataReceiving(CallbackQuery callbackQuery, ChatId chatId);
    }
}
