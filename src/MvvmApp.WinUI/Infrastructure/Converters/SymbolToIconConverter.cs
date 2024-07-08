using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using System;

namespace MvvmApp.WinUI.Infrastructure.Converters;
public class SymbolToIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string symbolString)
        {
            var symbol = (Symbol)Enum.Parse(typeof(Symbol), symbolString);
            return new SymbolIcon(symbol);
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}

