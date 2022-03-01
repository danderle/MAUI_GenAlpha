using GenAlphaMaui.Resources.Strings;

namespace GenAlphaMaui.ViewModels;

public class ShellViewModel
{
    public AppSection GameSelection { get; set; }

    public ShellViewModel()
    {
        GameSelection = new AppSection()
        {
            Title = AppResource.GameSelection,
            TargetType = typeof(GameSelectionPage),
        };
    }
}
