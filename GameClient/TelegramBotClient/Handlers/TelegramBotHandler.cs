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
    public TelegramBotHandler(ITextMessageHandler messageHandler)
    {
        _messageHandler = messageHandler;
    }
    public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        switch (update.Type)
        {
            case UpdateType.Message:
                var message = update.Message?.Text;
                var chatId = update.Message.Chat.Id;

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
                break;
        }
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
