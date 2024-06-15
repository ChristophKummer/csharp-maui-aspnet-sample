using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace CustomApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Create builder
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
            // Configure application
            builder.UseMauiApp<App>();

            // Configure fonts
            builder.ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }
            );

#if DEBUG
            // Configure debugger
            builder.Logging.AddDebug();
#endif

            // Build application
            return builder.Build();
        }
    }
}
