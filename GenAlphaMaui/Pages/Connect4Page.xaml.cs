namespace GenAlphaMaui.Pages;

public partial class Connect4Page : ContentPage
{
	public Connect4Page(Connect4ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}