using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.SettingsPage;

public class SettingsPageViewModelFactory(
    ILocalizeServiceFactory localizeServiceFactory) : PageViewModelFactoryBase<SettingsPageViewModel>
{
    private readonly ILocalizeService<SettingsPageLoc> localizeService = localizeServiceFactory.Invoke<SettingsPageLoc>();
    public override SettingsPageViewModel Invoke()
    {
        var vm = new SettingsPageViewModel();
        localizeService.SetupLocalization(vm);
        return vm;
    }
}