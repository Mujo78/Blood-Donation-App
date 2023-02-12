using CommunityToolkit.Maui;
using DarujKrv.Data;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;

namespace DarujKrv;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseLocalNotification()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<Registration>();
        builder.Services.AddSingleton<UserRepository>();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
