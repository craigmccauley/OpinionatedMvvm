using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.NoNavPage;
public static class DependencyInjection
{
    public static void AddFeaturesNoNavPage(this IServiceCollection services)
    {
        services.AddSingleton<IPageViewModelFactory, NoNavPageViewModelFactory>();
        services.AddSingleton<INavigateToNavPageCommand, NavigateToNavPageCommand>();
    }
}
