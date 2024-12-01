using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="BooleanConverter"/>
/// </summary>
/// <seealso cref="TrueFalseConverter{Boolean}" />
public class BooleanConverter : TrueFalseConverter<bool>
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    protected override object? Convert(bool value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value ? True : False;
    }
}
