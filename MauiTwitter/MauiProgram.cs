namespace MauiTwitter;

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
                fonts.AddFont("Robato-Regular.ttf", "RobatoRegular");
                fonts.AddFont("Robato-Bold.ttf", "RobatoBold");
                fonts.AddFont("fa-solid-900.ttf", "fasolid");
			});

		return builder.Build();
	}
}
