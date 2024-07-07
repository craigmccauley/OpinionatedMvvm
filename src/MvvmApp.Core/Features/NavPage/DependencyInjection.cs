using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Features.NavPage;

namespace MvvmApp.Core.Features.NavPage;
public static class DependencyInjection
{
    public static void AddFeaturesNavPage<TNavigationViewSelectionChangedEventArgsToNavigationArgsMap>(this IServiceCollection services) 
        where TNavigationViewSelectionChangedEventArgsToNavigationArgsMap : class, INavigationViewSelectionChangedEventArgsToNavigationArgsMap
    {
        services.AddSingleton<IPageViewModelFactory, NavPageViewModelFactory>();
        services.AddSingleton<ISelectionChangedCommand, SelectionChangedCommand>();
        services.AddSingleton<INavPageNavigationService, NavPageNavigationService>();
        services.AddSingleton<INavigationViewSelectionChangedEventArgsToNavigationArgsMap, TNavigationViewSelectionChangedEventArgsToNavigationArgsMap>();
    }
}
