namespace Promise.Converter;

/// <summary>
/// a class of <see cref="TrueFalseOrNullConverter{T}"/>
/// </summary>
/// <seealso cref="IValueConverter" />

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TrueFalseOrNullConverter<T> : TrueFalseConverter<T>, IValueConverter
{
    /// <summary>
    ///  null value
    /// </summary>
    public object? Null
    {
        get { return GetValue(NullProperty); }
        set { SetValue(NullProperty, value); }
    }

    /// <summary>
    /// The null property
    /// </summary>
    public static readonly DependencyProperty NullProperty = PropertyRegister.Register<TrueFalseOrNullConverter<T>, object>(i => i.Null!, null!);
}
