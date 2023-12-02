using Microsoft.Extensions.DependencyInjection;

namespace TelegramBotClient.Handlers.Services;
internal interface IServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services);
}
