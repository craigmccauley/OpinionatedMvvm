using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.WelcomePage;
public static class DependencyInjection
{
    public static void AddFeaturesWelcomePage(this IServiceCollection services)
    {
        services.AddSingleton<IPageViewModelFactory, WelcomePageViewModelFactory>();
        services.AddSingleton<INavigateToNoNavPageCommand, NavigateToNoNavPageCommand>();
        services.AddSingleton<INavigateToFormPageCommand, NavigateToFormPageCommand>();
    }
}
