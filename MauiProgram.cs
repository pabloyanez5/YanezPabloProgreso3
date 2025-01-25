using MAUI_Aeropuertos.Services;
using Microsoft.Extensions.Logging;
using System.IO;

namespace MAUI_Aeropuertos
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            
            builder.Services.AddSingleton(new DatabaseService(Path.Combine(FileSystem.AppDataDirectory, "AeropuertosDB.db3")));

            return builder.Build();
        }
    }

}
