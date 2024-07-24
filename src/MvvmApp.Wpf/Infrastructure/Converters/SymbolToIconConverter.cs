using ModernWpf.Controls;
using System.Globalization;
using System.Windows.Data;

namespace MvvmApp.Wpf.Infrastructure.Converters;
public class SymbolToIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter,CultureInfo culture)
    {
        if (value is string symbolString)
        {
            var symbol = (Symbol)Enum.Parse(typeof(Symbol), symbolString);
            return new SymbolIcon(symbol);
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

