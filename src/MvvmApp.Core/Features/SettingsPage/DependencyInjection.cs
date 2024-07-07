using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.SettingsPage;
public static class DependencyInjection
{
    public static void AddFeaturesSettingsPage(this IServiceCollection services)
    {
        services.AddSingleton<IPageViewModelFactory, SettingsPageViewModelFactory>();
    }
}
