namespace GenAlphaMaui.ViewModels;

/// <summary>
/// The view model for the game selection buttons
/// </summary>
public class GameSelectionButtonViewModel : BaseViewModel
{
    #region Properties

    /// <summary>
    /// The text for this button
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// The name of the page this button represents
    /// </summary>
    public string NameOfPage { get; set; }

    #endregion

    #region Commands

    /// <summary>
    /// The command for clicking
    /// </summary>
    public ICommand ClickCommand { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Default constructor
    /// </summary>
    public GameSelectionButtonViewModel()
    {
        InitializeCommands();
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    public GameSelectionButtonViewModel(string text, string nameOfPage)
    {
        InitializeCommands();
        Text = text;
        NameOfPage = nameOfPage;
    }

    #endregion

    #region Command Methods

    /// <summary>
    /// The click command method
    /// </summary>
    private async void Click()
    {
        await Shell.Current.GoToAsync($"{NameOfPage}");
    }

    #endregion

    #region Private Helpers Methods

    private void InitializeCommands()
    {
        ClickCommand = new RelayCommand(Click);
    }

    #endregion
}
