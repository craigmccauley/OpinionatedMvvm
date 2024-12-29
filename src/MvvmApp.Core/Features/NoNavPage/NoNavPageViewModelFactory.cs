using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.NoNavPage;

public class NoNavPageViewModelFactory(
    ILocalizeServiceFactory localizeServiceFactory,
    INavigateToNavPageCommand navigateToNavPageCommand) 
    : PageViewModelFactoryBase<NoNavPageViewModel>
{
    private readonly ILocalizeService<NoNavPageLoc> localizeService = localizeServiceFactory.Invoke<NoNavPageLoc>();

    public override NoNavPageViewModel Invoke()
    {
        var vm = new NoNavPageViewModel
        {
            NavigateToNavPageCommand = navigateToNavPageCommand
        };

        localizeService.SetupLocalization(vm);

        return vm;
    }
}