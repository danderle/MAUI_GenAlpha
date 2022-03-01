using System.Diagnostics;
using System.Globalization;

namespace GenAlphaMaui.Converters;

/// <summary>
/// Converts a <see cref="Connect4ChipStates"/>to Color
/// </summary>
class ChipStateToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        Connect4ChipStates chipState = (Connect4ChipStates)value;
        object color;
        switch(chipState)
        {
            case Connect4ChipStates.StartUnselected:
                Application.Current.Resources.TryGetValue("LightGray", out color);
                break;
            case Connect4ChipStates.Player1:
                Application.Current.Resources.TryGetValue("Player1Red", out color);
                break;
            case Connect4ChipStates.Player2:
                Application.Current.Resources.TryGetValue("Player2Yellow", out color);
                break;
            case Connect4ChipStates.GameOverUnselected:
                Application.Current.Resources.TryGetValue("VeryDarkBlue", out color);
                break;
            default:
                Debugger.Break();
                Application.Current.Resources.TryGetValue("LightGray", out color);
                break;
        }
        return color;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
