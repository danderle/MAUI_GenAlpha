namespace GenAlphaMaui.ViewModels;

/// <summary>
/// A base class for the top bar
/// </summary>
public class BaseTopBarViewModel : BaseViewModel
{
    #region Commands

    /// <summary>
    /// The command to go back to the game selection menu
    /// </summary>
    public ICommand ToGameSelectionCommand { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Default constructor
    /// </summary>
    public BaseTopBarViewModel()
    {
        InitializeCommands();
    }

    #endregion

    #region Command Methods

    /// <summary>
    /// Switches the page to return to the game selection page
    /// </summary>
    private async void GoToGameSelctionAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(GameSelectionPage)}");
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Initializes the commands
    /// </summary>
    private void InitializeCommands()
    {
        ToGameSelectionCommand = new RelayCommand(GoToGameSelctionAsync);
    }

    #endregion
}
