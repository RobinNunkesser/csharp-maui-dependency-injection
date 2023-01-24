using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DependencyInjection;

enum Environment
{
    Development,
    Staging,
    Production
}

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var env = Environment.Production;
#if DEBUG
        env = Environment.Development;
#endif
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        switch (env)
        {
            case Environment.Development:
                builder.Logging.AddDebug();
                builder.Services.AddSingleton<
                    IMessageWriter,
                    ConsoleMessageWriter
                >();
                break;
            case Environment.Staging:
            case Environment.Production:
            default:
                builder.Services.AddSingleton<
                    IMessageWriter,
                    DebugMessageWriter
                >();
                break;
        }
        return builder.Build();
    }
}
