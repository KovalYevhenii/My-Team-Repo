using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TelegramBotClient.Models;

namespace TelegramBotClient.Services
{
    public class ApiClient : IDisposable
    {
        private HttpClient client;

        private string apiUrl = "localhost";
        private string errMsg = "";
        private string sessionId = "";

        public ApiClient()
        {
            client = new HttpClient();
            client.Timeout = Timeout.InfiniteTimeSpan;
        }

        public string? GetSessionID(ChatId chatId)
        {
            errMsg = "";
            try
            {
                HttpResponseMessage _sessionId = client.PostAsJsonAsync<long?>("get/user/sessionId", chatId.Identifier).Result;
                if (_sessionId.StatusCode != HttpStatusCode.OK)
                {
                    errMsg = $"Ошибка получения сесии: {_sessionId.Content.ReadAsStringAsync().Result}";
                    return null;
                }
                return JsonConvert.DeserializeObject<string>(_sessionId.Content.ReadAsStringAsync().Result);
            }
            catch (Exception)
            {
                return null;
            }
        }


        public Dictionary<string, HeroType>? GetHero(long sessionId)
        {
            errMsg = "";
            try
            {
                HttpResponseMessage _hero = client.PostAsJsonAsync<long?>("get/hero", sessionId).Result;
                if (_hero.StatusCode != HttpStatusCode.OK)
                {
                    errMsg = $"Ошибка создания героя: {_hero.Content.ReadAsStringAsync().Result}";
                    return null;
                }
                return JsonConvert.DeserializeObject<Dictionary<string, HeroType>>(_hero.Content.ReadAsStringAsync().Result);
            }
            catch (Exception)
            {
                return null;
            }
        }



        public void Dispose()
        {
            client.Dispose();
        }
    }
}
