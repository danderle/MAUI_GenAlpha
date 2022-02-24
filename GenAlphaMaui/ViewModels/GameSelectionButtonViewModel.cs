using System.Windows.Input;

namespace GenAlphaMaui;

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
    /// The game page this button represents
    /// </summary>
    public ApplicationPage GamePage { get; set; }

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
    public GameSelectionButtonViewModel(string text, ApplicationPage gamePage)
    {
        InitializeCommands();
        Text = text;
        GamePage = gamePage;
    }

    #endregion

    #region Command Methods

    /// <summary>
    /// The click command method
    /// </summary>
    private void Click()
    {
        DI.Service<ApplicationViewModel>().GoToPage(GamePage);
    }

    #endregion

    #region Private Helpers Methods

    private void InitializeCommands()
    {
        ClickCommand = new RelayCommand(Click);
    }

    #endregion
}
