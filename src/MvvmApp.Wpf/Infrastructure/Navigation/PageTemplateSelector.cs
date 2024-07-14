using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MvvmApp.Wpf.Infrastructure.Navigation;
public class PageTemplateSelector : DataTemplateSelector
{
    public List<DataTemplate> DataTemplateCollection { get; set; } = [];

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        return GetTemplate(item) ?? base.SelectTemplate(item, container);
    }

    private DataTemplate GetTemplate(object item)
    {
        if (item == null)
        {
            return DataTemplateCollection.FirstOrDefault();
        }
        var type = item.GetType();
        return DataTemplateCollection.FirstOrDefault(template => (Type)template.DataType == type);
    }
}
