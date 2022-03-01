using System.Globalization;

namespace GenAlphaMaui.Converters;

/// <summary>
/// Converts a <see cref="PlayerTurn"/>to Color
/// </summary>
class CurrentPlayerToTextColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        object color;
        if((bool)value)
        {
            Application.Current.Resources.TryGetValue("Green", out color);
        }
        else
        {
            Application.Current.Resources.TryGetValue("Gray", out color);
        }
        return color;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
