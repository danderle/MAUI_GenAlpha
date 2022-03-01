namespace GenAlphaMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureViewModels()
			.ConfigureMauiHandlers(handlers =>
			{
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Font Awesome 5 Free-Regular-400.otf", "FontAwesomeRegular");
                fonts.AddFont("Font Awesome 5 Free-Solid-900.otf", "FontAwesomeSolid");
            });

		return builder.Build();
	}
}
