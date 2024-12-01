using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="BooleanReverseConverter"/>
/// </summary>
/// <seealso cref="TrueFalseConverter{Boolean}" />
public class BooleanReverseConverter : TrueFalseConverter<bool>
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
        return value ? False : True;
    }
}
