using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="BooleanToVisibilityReverseConverter"/>
/// </summary>
/// <seealso cref="ValueConverterBase{Boolean}" />
public class BooleanToVisibilityReverseConverter : ValueConverterBase<bool>
{
    /// <summary>
    ///  convert
    /// </summary>
    /// <param name="boolValue"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    protected override object? Convert(bool boolValue, Type targetType, object? parameter, CultureInfo culture)
    {
        return !boolValue ? Visibility.Visible : Visibility.Collapsed;
    }
}
