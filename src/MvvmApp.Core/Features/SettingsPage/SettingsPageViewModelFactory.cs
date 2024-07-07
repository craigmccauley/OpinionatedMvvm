using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.SettingsPage;

public class SettingsPageViewModelFactory : PageViewModelFactoryBase<SettingsPageViewModel>
{
    public override SettingsPageViewModel Invoke() => new();
}