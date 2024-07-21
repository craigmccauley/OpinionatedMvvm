using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Wpf.Pages;
using System.Globalization;
using System.Windows.Data;
using Wpf.Ui.Controls;

namespace MvvmApp.Wpf.Infrastructure.Converters
{
    public class MenuItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not IEnumerable<Core.Features.NavPage.MenuItem> items)
            {
                return null;
            }

            return items.Select(i => new NavigationViewItem
            {
                Content = i.Content,
                Icon = new SymbolIcon(SymbolGlyph.Parse(i.Glyph)),
                TargetPageType = MapToPage(i.NavDestination),
                IsActive = i.IsSelected,
                DataContext = i.Parent.SelectedView
            });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static Type MapToPage(AppPage viewModelPage)
        {
            if (viewModelPage == AppPages.MainPage)
            {
                return typeof(MainPage);
            }
            else if (viewModelPage == AppPages.NoNavPage)
            {
                return typeof(NoNavPage);
            }
            else if (viewModelPage == AppPages.NavPage)
            {
                return typeof(NavPage);
            }
            else if (viewModelPage == AppPages.WelcomePage)
            {
                return typeof(WelcomePage);
            }
            else if (viewModelPage == AppPages.FormPage)
            {
                return typeof(FormPage);
            }
            else if (viewModelPage == AppPages.SettingsPage)
            {
                return typeof(SettingsPage);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
