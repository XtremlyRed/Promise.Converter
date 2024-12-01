global using System;
global using System.ComponentModel;
global using static System.Diagnostics.DebuggerBrowsableState;
global using System.Linq;
global using System.Runtime.InteropServices;
global using Avalonia;
global using Avalonia.Data;
global using Avalonia.Data.Converters;
global using Avalonia.Markup;
global using Avalonia.Media;
global using Avalonia.Metadata;
global using static Promise.Converter.PropertyRegister;
global using Application = Avalonia.Application;
global using BF = System.Reflection.BindingFlags;
global using Binding = Avalonia.Data.Binding;
global using Brush = Avalonia.Media.Brush;
global using Brushes = Avalonia.Media.Brushes;
global using Button = Avalonia.Controls.Button;
global using Color = Avalonia.Media.Color;
global using ComboBox = Avalonia.Controls.ComboBox;
global using DBA = System.Diagnostics.DebuggerBrowsableAttribute;
global using DependencyObject = Avalonia.AvaloniaObject;
global using DependencyProperty = Avalonia.AvaloniaProperty;
global using Panel = Avalonia.Controls.Panel;
global using Point = Avalonia.Point;
global using Size = Avalonia.Size;
global using TextBox = Avalonia.Controls.TextBox;
global using UserContorl = Avalonia.Controls.UserControl;

[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "Promise.Converter")]
[assembly: XmlnsDefinition("https://github.com/xtremlyred/promise.converter", "Promise.Converter")]
[assembly: XmlnsPrefix("Promise.Converter", "promise")]

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}
