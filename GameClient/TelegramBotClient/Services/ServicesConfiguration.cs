using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Telegram.Bot;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Interfaces;
namespace TelegramBotClient.Handlers.Services;
public class ServicesConfiguration : IServicesConfiguration
{
    private readonly string _token;
    public ServicesConfiguration(string token)
    {
        _token = token;
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient();
        services.TryAddSingleton((ITelegramBotClient)new Telegram.Bot.TelegramBotClient(_token));
        services.TryAddSingleton<ITelegramBotHandler, TelegramBotHandler>();
        services.TryAddSingleton<ITextMessageHandler, TextMessageHandler>();
        services.TryAddSingleton<IBotRunner, BotRunner>();
        services.TryAddSingleton<IGameKeyboard, GameKeyboard>();
        services.TryAddSingleton<ICallbackHandler, CallBackHandler>();
        services.TryAddSingleton<ICallbackManager, CallbackManager>();
        services.TryAddSingleton<ICallBackRegistrator, CallbackRegistrator>();
    }
}
