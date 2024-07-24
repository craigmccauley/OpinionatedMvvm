using ModernWpf.Controls;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Features.NavPage;

namespace MvvmApp.Wpf.Features.NavPage;
public class NavigationViewSelectionChangedEventArgsToNavigationArgsMap(
    IPageViewModelGetterService pageViewModelGetterService) : INavigationViewSelectionChangedEventArgsToNavigationArgsMap
{
    public NavigationArgs Map(object src)
    {
        if (src is not NavigationViewSelectionChangedEventArgs args)
        {
            return new NavigationArgs
            {
                SelectedPage = AppPages.WelcomePage,
                NavPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.NavPage) as NavPageViewModel,
            }; 
        }

        if (args.IsSettingsSelected)
        {
            return new NavigationArgs
            {
                SelectedPage = AppPages.SettingsPage,
                NavPageViewModel = (args.SelectedItem as NavigationViewItem).DataContext as NavPageViewModel
            };
        }
        else if (args.SelectedItem is MenuItem menuItem)
        {
            return new NavigationArgs
            {
                SelectedPage = menuItem.NavDestination,
                NavPageViewModel = menuItem.Parent
            };
        }

        return null;
    }
}
