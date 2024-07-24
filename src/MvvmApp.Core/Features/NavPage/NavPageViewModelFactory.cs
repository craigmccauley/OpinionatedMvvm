using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;

namespace MvvmApp.Core.Features.NavPage;

public class NavPageViewModelFactory(
    IMessenger messenger,
    ISelectionChangedCommand selectionChangedCommand,
    INavPageNavigationService navPageNavigationService) 
    : PageViewModelFactoryBase<NavPageViewModel>
{
    public override NavPageViewModel Invoke()
    {
        var vm = new NavPageViewModel
        {
            MenuItems = [],
            SelectionChangedCommand = selectionChangedCommand
        };

        var firstMenuItem = new MenuItem
        {
            Content = "Home",
            Glyph = "Home",
            NavDestination = AppPages.WelcomePage,
            Parent = vm,
            IsSelected = true,
        };

        vm.MenuItems.Add(firstMenuItem);

        vm.MenuItems.Add(new()
        {
            Content = "Form",
            Glyph = "Page",
            NavDestination = AppPages.FormPage,
            Parent = vm,
        });

        vm.SelectedMenuItem = firstMenuItem;
        messenger.Register<NavPageViewModel, ChangeNavPageMessage>(vm, navPageNavigationService.OnNavigationMessageReceived);

        return vm;
    }
}