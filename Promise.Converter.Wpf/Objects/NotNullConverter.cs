using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="NotNullToVisitilityConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class NotNullToVisitilityConverter : NotNullConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public NotNullToVisitilityConverter()
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
