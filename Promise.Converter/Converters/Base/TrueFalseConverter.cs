﻿namespace Promise.Converter;

/// <summary>
/// a class of <see cref="TrueFalseConverter{T}"/>
/// </summary>
/// <seealso cref="IValueConverter" />

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TrueFalseConverter<T> : ValueConverterBase<T>, IValueConverter
{
    /// <summary>
    /// true value
    /// </summary>
    public object True
    {
        get => GetValue(TrueProperty)!;
        set => SetValue(TrueProperty, value);
    }

    /// <summary>
    ///  false value
    /// </summary>
    public object False
    {
        get => GetValue(FalseProperty)!;
        set => SetValue(FalseProperty, value);
    }

    /// <summary>
    /// The true property
    /// </summary>
    private static readonly DependencyProperty TrueProperty = PropertyRegister.Register<TrueFalseConverter<T>, object>(i => i.True, null!);

    /// <summary>
    /// The false property
    /// </summary>
    private static readonly DependencyProperty FalseProperty = PropertyRegister.Register<TrueFalseConverter<T>, object>(i => i.False, null!);
}
