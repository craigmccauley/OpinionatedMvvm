using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;

namespace MvvmApp.WinUI.Infrastructure.Navigation;
public class PageTemplateSelector : DataTemplateSelector
{
    public List<DataTemplate> DataTemplateCollection { get; set; } = [];
    protected override DataTemplate SelectTemplateCore(object item) =>
        GetTemplate(item) ?? base.SelectTemplateCore(item);
    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) =>
        GetTemplate(item) ?? base.SelectTemplateCore(item, container);

    private DataTemplate GetTemplate(object item)
    {
        if (item == null)
        {
            return null;
        }
        var type = item.GetType();
        return DataTemplateCollection.FirstOrDefault(template => Element.GetDataType(template) == type);
    }
}
