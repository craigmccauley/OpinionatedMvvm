using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.MainPage;
public static class DependencyInjection
{
    public static void AddFeaturesMainPage(this IServiceCollection services)
    {
        services.AddSingleton<IPageViewModelFactory, MainPageViewModelFactory>();
        services.AddSingleton<IMainPageNavigationService, MainPageNavigationService>();
    }
}
