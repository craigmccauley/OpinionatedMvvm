using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.FormPage;

public class FormPageViewModelFactory(
    ILocalizeServiceFactory localizeServiceFactory) : PageViewModelFactoryBase<FormPageViewModel>
{
    private readonly ILocalizeService<FormPageLoc> localizeService = localizeServiceFactory.Invoke<FormPageLoc>();
    public override FormPageViewModel Invoke()
    {
        var vm = new FormPageViewModel();
        localizeService.SetupLocalization(vm);
        return vm;
    }
}