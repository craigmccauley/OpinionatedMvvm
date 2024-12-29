using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Features.FormPage;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Features.NoNavPage;
using MvvmApp.Core.Features.SettingsPage;
using MvvmApp.Core.Features.WelcomePage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Localization;
using MvvmApp.Features.NavPage;
using System;
using Windows.UI.Core;

namespace MvvmApp.Uwp.Infrastructure.Application;
public static class ApplicationSetup
{
    public static IServiceProvider BuildServiceProvider()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);
        services.AddSingleton<IDispatcher, Dispatcher>();

        services.AddSingleton<ISuspendingService, SuspendingService>();
        services.AddSingleton<ILaunchedService, LaunchedService>();

        services.AddSingleton<IPageViewModelCreatorService, PageViewModelCreatorService>();
        services.AddSingleton<IPageViewModelGetterService, PageViewModelCreatorService.PageViewModelGetterService>();
        services.AddSingleton<IPageFactory, PageFactory>();

        services.AddSingleton<INavigationFailedService, NavigationFailedService>();

        services.AddFeaturesFormPage();
        services.AddFeaturesMainPage();
        services.AddFeaturesNavPage<NavigationViewSelectionChangedEventArgsToNavigationArgsMap>();
        services.AddFeaturesNoNavPage();
        services.AddFeaturesSettingsPage();
        services.AddFeaturesWelcomePage();

        services.AddInfrastructureLocalization();

        return services.BuildServiceProvider();
    }
}
