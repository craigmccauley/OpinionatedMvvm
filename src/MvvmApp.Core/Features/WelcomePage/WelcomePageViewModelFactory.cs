using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.WelcomePage;

public class WelcomePageViewModelFactory(
    INavigateToNoNavPageCommand navigateToNoNavPageCommand,
    INavigateToFormPageCommand navigateToFormPageCommand,
    ILocalizeServiceFactory localizeServiceFactory) : PageViewModelFactoryBase<WelcomePageViewModel>
{
    private readonly ILocalizeService<WelcomePageLoc> localizeService = localizeServiceFactory.Invoke<WelcomePageLoc>();
    public override WelcomePageViewModel Invoke()
    {

        var vm = new WelcomePageViewModel
        {
            NavigateToNoNavPageCommand = navigateToNoNavPageCommand,
            NavigateToFormPageCommand = navigateToFormPageCommand,
        };

        localizeService.SetupLocalization(vm);

        return vm;
    }
}