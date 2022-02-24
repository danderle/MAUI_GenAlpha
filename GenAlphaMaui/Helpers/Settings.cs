namespace GenAlphaMaui.Helpers;

public static class Settings
{
    const OSAppTheme theme = OSAppTheme.Light;

    public static OSAppTheme Theme
    {
        get => Enum.Parse<OSAppTheme>(Preferences.Get(nameof(Theme), Enum.GetName(theme)));
        set => Preferences.Set(nameof(Theme), value.ToString());
    }
}
