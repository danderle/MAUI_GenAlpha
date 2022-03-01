namespace GenAlphaMaui.ViewModels;

/// <summary>
/// The view model for the <see cref="GameSelectionPage"/>
/// </summary>
public class GameSelectionViewModel : BaseViewModel
{
    #region Private Members

    #endregion

    #region Properties

    /// <summary>
    /// The list of games available
    /// </summary>
    public List<GameSelectionButtonViewModel> Games { get; set; } = new List<GameSelectionButtonViewModel>();

    #endregion

    #region Constructor

    /// <summary>
    /// Default constructor
    /// </summary>
    public GameSelectionViewModel()
    {
        //Games.Add(new GameSelectionButtonViewModel("Memory Game", nameof(Memor));
        //Games.Add(new GameSelectionButtonViewModel("Keyboard shooter", ApplicationPage.KeyboardShooter));
        Games.Add(new GameSelectionButtonViewModel("Connect-4", nameof(Connect4Page)));
        //Games.Add(new GameSelectionButtonViewModel("Minesweeper", ApplicationPage.Minesweeper));
        //Games.Add(new GameSelectionButtonViewModel("Guess the animal", ApplicationPage.GuessAnimal));
    }

    #endregion
}
