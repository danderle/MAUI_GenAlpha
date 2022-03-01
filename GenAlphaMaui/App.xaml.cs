namespace GenAlphaMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        InitializeComponent();

        TheTheme.SetTheme();

        if (Config.Desktop)
            MainPage = new DesktopShell();
        else
            MainPage = new MobileShell();

        Routing.RegisterRoute(nameof(Connect4Page), typeof(Connect4Page));
        Routing.RegisterRoute(nameof(GameSelectionPage), typeof(GameSelectionPage));

    }
}
