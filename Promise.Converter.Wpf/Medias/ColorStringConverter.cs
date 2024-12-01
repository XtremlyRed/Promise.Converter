namespace Promise.Converter;

/// <summary>
/// a class of <see cref="ColorStringConverter"/>
/// </summary>
public class ColorStringConverter : MediaConverter<string, Color>
{
    static BrushConverter brushConverter = new BrushConverter();

    /// <summary>
    /// convert from
    /// </summary>
    /// <param name="from"></param>
    /// <returns></returns>
    protected override Color ConvertFrom(string from)
    {
        return (Color)ColorConverter.ConvertFromString(from);
    }
}
