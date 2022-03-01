using System.Globalization;

namespace GenAlphaMaui.Converters;

/// <summary>
/// Converts a <see cref="SettingTypes"/>to bool
/// </summary>
public class SettingTypeToBoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var setting = value.ToString();
        var converterParameter = (string)parameter;
        return setting == converterParameter;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
