using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.WelcomePage;

public class WelcomePageViewModelFactory(
    INavigateToNoNavPageCommand navigateToNoNavPageCommand,
    INavigateToFormPageCommand navigateToFormPageCommand) : PageViewModelFactoryBase<WelcomePageViewModel>
{
    public override WelcomePageViewModel Invoke()
    {

        var vm = new WelcomePageViewModel
        {
            NavigateToNoNavPageCommand = navigateToNoNavPageCommand,
            NavigateToFormPageCommand = navigateToFormPageCommand,
        };
        return vm;
    }
}