using Microsoft.Extensions.DependencyInjection;
using TelegramBotClient.Handlers.Interfaces;
using TelegramBotClient.Handlers.Services;

namespace TelegramBotClient;
internal class Program
{
    private static async Task Main(string[] args)
    {
        string token = Environment.GetEnvironmentVariable("My_Team_Token")?? throw new ArgumentNullException(nameof(token));

        // Configure dependency injection
        var services = new ServiceCollection();
        var serviceConfig = new ServicesConfiguration(token);
        serviceConfig.ConfigureServices(services);
        var serviceProvider = services.BuildServiceProvider();
        // Get required services

        var botRunner = serviceProvider.GetRequiredService<IBotRunner>();
        CancellationTokenSource cts = new();
        await botRunner.RunBotAsync(cts.Token);

        Console.ReadLine();
        cts.Cancel();
    }
}
