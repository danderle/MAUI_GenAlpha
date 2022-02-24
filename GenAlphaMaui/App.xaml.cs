using GenAlphaMaui.Pages;

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
    }
}
