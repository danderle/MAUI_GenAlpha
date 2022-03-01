﻿namespace GenAlphaMaui.Helpers;

public static class TheTheme
{
    public static void SetTheme()
    {
        switch (Settings.Theme)
        {
            default:
                case OSAppTheme.Light:
                    App.Current.UserAppTheme = OSAppTheme.Light;
                    break;
                case OSAppTheme.Dark:
                App.Current.UserAppTheme = OSAppTheme.Dark;
                break;
        }

    }
}
