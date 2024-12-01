namespace Promise.Converter;

/// <summary>
/// a class of <see cref="NotEqualToVisitilityConverter"/>
/// </summary>
/// <seealso cref="NotEqualToVisitilityConverter" />
public class NotEqualToVisitilityConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public NotEqualToVisitilityConverter()
        : base(CompareMode.Equal)
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
