using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Promise.Converter;

/// <summary>
/// a class of <see cref="Converters"/>
/// </summary>
public static partial class Converters
{
    /// <summary>
    /// <see cref="Boolean"/> to <see cref="System.Windows.Visibility"/> converter
    /// </summary>
    public static BooleanToVisibilityConverter BooleanToVisibility = new();

    /// <summary>
    /// <see cref="Boolean"/> to <see cref="System.Windows.Visibility"/> reverse converter
    /// </summary>
    public static BooleanToVisibilityReverseConverter BooleanToVisibilityReverse = new();

    /// <summary>
    /// <see cref="string"/> to Color converter
    /// </summary>

    public readonly static ColorStringConverter StringToColor = new();
}
