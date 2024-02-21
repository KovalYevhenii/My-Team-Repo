using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBotClient.Handlers.Interfaces;

namespace TelegramBotClient.Handlers
{
    public class CallBackHandler : ICallbackHandler
    {
        private readonly ITelegramBotClient _botClient;
        private readonly IGameKeyboard _keyboardWithCallback;
        private readonly HttpClient _httpClient;
        public CallBackHandler(ITelegramBotClient botClient, IGameKeyboard gameKeyboard, HttpClient httpClient)
        {
            _httpClient = httpClient;
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
                    var responce = await _httpClient.GetAsync($"https://localhost:7048/api/user/Session?chatId={chatId.Identifier}");
                    if (responce.IsSuccessStatusCode)
                    {
                        var json = await responce.Content.ReadAsStringAsync();
                        var session = JsonSerializer.Deserialize<Dictionary<string, bool>>(json);
                        foreach (var item in session)
                        {
                            Console.WriteLine($"{item.Value} {item.Key}");
                        }
                    }
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
