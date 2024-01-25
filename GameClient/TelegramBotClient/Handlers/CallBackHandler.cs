using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotClient.Handlers.Interfaces;

namespace TelegramBotClient.Handlers
{
    public class CallBackHandler : ICallbackHandler
    {
        private readonly ITelegramBotClient _botClient;
        private readonly IGameKeyboard _keyboardWithCallback;
        public CallBackHandler(ITelegramBotClient botClient, IGameKeyboard gameKeyboard)
        {
            _botClient = botClient;
            _keyboardWithCallback = gameKeyboard;
        }

        public async Task BotOnCallbackDataReceiving(CallbackQuery callbackQuery, ChatId chatId)
        {
            switch (callbackQuery.Data)
            {
                case "Однопользовательская":
                    await _keyboardWithCallback.StartingGameKeyboard(_botClient, chatId);
                    break;
                case "Многопользовательская":
                    await _keyboardWithCallback.StartingGameKeyboard(_botClient, chatId);
                    break;
                case "Yes":
                    // handle game start confirmation
                    break;
                case "No":
                    // handle game start cancellation
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
