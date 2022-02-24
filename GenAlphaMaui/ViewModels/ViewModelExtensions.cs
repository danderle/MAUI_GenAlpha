namespace GenAlphaMaui.ViewModels;

public static class ViewModelExtensions
{
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<GameSelectionViewModel>();
        builder.Services.AddSingleton<ShellViewModel>();

        return builder;
    }
}
