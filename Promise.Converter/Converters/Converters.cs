using System.Collections;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="Converters"/>
/// </summary>
public static partial class Converters
{
    /// <summary>
    ///  <see cref="Boolean"/> reverse converter
    /// </summary>
    public readonly static BooleanReverseConverter BooleanReverse = new() { True = true, False = false };

    /// <summary>
    /// <see cref="string"/> to Brush converter
    /// </summary>

    public readonly static BrushStringConverter StringToBrush = new();

    /// <summary>
    /// get <see cref="IEnumerable"/> count
    /// </summary>
    public readonly static LengthConverter Length = new();

    /// <summary>
    /// <see cref="IEnumerable"/> <see langword="null"/> or empty to <see cref="bool"/> converter
    /// </summary>
    public readonly static NullOrEmptyConverter NullOrEmpty = new() { True = true, False = false };

    /// <summary>
    /// <see cref="IEnumerable"/> not <see langword="null"/> or empty to <see cref="bool"/> converter
    /// </summary>
    public readonly static NotNullOrEmptyConverter NotNullOrEmpty = new() { True = true, False = false };

    /// <summary>
    /// <see cref="string"/> <see langword="null"/> or white space to <see cref="bool"/> converter
    /// </summary>
    public readonly static NullOrWhiteSpaceConverter NullOrWhiteSpace = new() { True = true, False = false };

    /// <summary>
    /// <see cref="string"/> not <see langword="null"/> or white space to <see cref="bool"/> converter
    /// </summary>
    public readonly static NotNullOrWhiteSpaceConverter NotNullOrWhiteSpace = new() { True = true, False = false };

    /// <summary>
    /// <see cref="object"/> <see langword="null"/> to <see cref="bool"/> converter
    /// </summary>
    public readonly static NullConverter Null = new() { True = true, False = false };

    /// <summary>
    /// <see cref="object"/> not <see langword="null"/> to <see cref="bool"/> converter
    /// </summary>
    public readonly static NotNullConverter NotNull = new() { True = true, False = false };
}
