namespace GenAlphaMaui.ViewModels;

public static class ViewModelExtensions
{
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<GameSelectionViewModel>();
        builder.Services.AddTransient<Connect4ViewModel>();
        builder.Services.AddSingleton<ShellViewModel>();

        return builder;
    }
}
