using MAUI_Aeropuertos.Services;
using Microsoft.Extensions.Logging;

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

            // Configurar la base de datos
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "AeropuertosDB.db3");
            builder.Services.AddSingleton(new DatabaseService(dbPath));

            return builder.Build();
        }
    }

}
