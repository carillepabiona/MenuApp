using MenuApp.Models;
using Microsoft.Extensions.Logging;
using MenuApp.Service;

namespace MenuApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<CartService>();
            builder.Services.AddSingleton<DatabaseService>();

            builder.Services.AddSingleton<TcpListenerService>();
            var app = builder.Build();

            // Start listening
            var tcpService = app.Services.GetRequiredService<TcpListenerService>();
            _ = tcpService.StartListeningAsync();


#endif

            return builder.Build();
        }
    }
}
