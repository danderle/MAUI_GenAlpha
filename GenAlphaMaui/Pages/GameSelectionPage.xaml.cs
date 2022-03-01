namespace GenAlphaMaui.Pages;

public partial class GameSelectionPage : ContentPage
{
	public GameSelectionPage(GameSelectionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}