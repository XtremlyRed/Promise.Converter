﻿namespace Promise.Converter;

/// <summary>
/// a class of <see cref="BrushStringConverter"/>
/// </summary>
public class BrushStringConverter : MediaConverter<string, Brush>
{
    static BrushConverter brushConverter = new BrushConverter();

    /// <summary>
    /// convert from
    /// </summary>
    /// <param name="from"></param>
    /// <returns></returns>
    protected override Brush ConvertFrom(string from)
    {
        return (Brush)brushConverter.ConvertFrom(from)!;
    }
}
