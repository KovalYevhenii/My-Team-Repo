using System.Text;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBotClient.Handlers.Interfaces;
namespace TelegramBotClient.Handlers;
internal class TelegramBotHandler : ITelegramBotHandler
{
    private readonly ITextMessageHandler _messageHandler;
    private readonly ICallbackHandler _callbackHandler;
    public TelegramBotHandler(ITextMessageHandler messageHandler, ICallbackHandler callbackHandler)
    {
        _messageHandler = messageHandler;
        _callbackHandler = callbackHandler;
    }
    public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        switch (update.Type)
        {
            case UpdateType.Message:
                var chatId = GetChatId(update);
                var message = update.Message?.Text;
                if (!string.IsNullOrEmpty(message))
                {
                    await _messageHandler.BotOnTextMessageReceiving(chatId, message);
                }
                else
                {
                    throw new NotImplementedException();
                }
                break;

            case UpdateType.CallbackQuery:
                var callbackQuery = update.CallbackQuery;
                var chatIdCallback = GetChatId(update);
                if (callbackQuery != null)
                {
                    await _callbackHandler.BotOnCallbackDataReceiving(callbackQuery, chatIdCallback);
                }

                break;
        }
    }
    private static ChatId GetChatId(Update update)
    {
        return update.Type switch
        {
            UpdateType.Message when update.Message != null
            => update.Message.Chat.Id,
            UpdateType.CallbackQuery when update.CallbackQuery?.Message != null
            => update.CallbackQuery.Message.Chat.Id,
            _ => throw new NotImplementedException()
        };
    }
    public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(ErrorMessage);
        return Task.CompletedTask;
    }
}
