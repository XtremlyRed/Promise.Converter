using System.Globalization;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="NullToVisitilityConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class NullToVisitilityConverter : NullConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public NullToVisitilityConverter()
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
