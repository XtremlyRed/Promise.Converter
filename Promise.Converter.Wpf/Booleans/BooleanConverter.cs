using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="BooleanToVisibilityConverter"/>
/// </summary>
/// <seealso cref="ValueConverterBase{Boolean}" />
public class BooleanToVisibilityConverter : ValueConverterBase<bool>
{
    /// <summary>
    /// convert
    /// </summary>
    /// <param name="boolValue"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected override object? Convert(bool boolValue, Type targetType, object? parameter, CultureInfo culture)
    {
        return boolValue ? Visibility.Visible : Visibility.Collapsed;
    }
}
