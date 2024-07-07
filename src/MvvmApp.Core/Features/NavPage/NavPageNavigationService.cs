using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Messages;
using System.Linq;

namespace MvvmApp.Core.Features.NavPage;

public interface INavPageNavigationService
{
    void OnNavigationMessageReceived(NavPageViewModel vm, ChangeNavPageMessage message);
}

public class NavPageNavigationService(
    IPageViewModelGetterService pageViewModelGetterService,
    IDispatcher dispatcher) : INavPageNavigationService
{
    public void OnNavigationMessageReceived(NavPageViewModel vm, ChangeNavPageMessage message)
    {
        var destination = pageViewModelGetterService.GetPageViewModel(message.Destination);
        if (destination == null)
        {
            return;
        }
        var menuItemToSelect = vm.MenuItems.FirstOrDefault(mi => mi.NavDestination == message.Destination);
        dispatcher.RunAsync(() =>
        {
            vm.SelectedView = destination;
            if(menuItemToSelect != null)
            {
                vm.SelectedMenuItem = menuItemToSelect;
            }
        });
    }
}
