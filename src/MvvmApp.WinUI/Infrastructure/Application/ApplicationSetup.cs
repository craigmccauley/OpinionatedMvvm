using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Features.FormPage;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Features.NoNavPage;
using MvvmApp.Core.Features.SettingsPage;
using MvvmApp.Core.Features.WelcomePage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.WinUI.Features.NavPage;
using System;

namespace MvvmApp.WinUI.Infrastructure.Application
{
    public static class ApplicationSetup
    {
        public static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IMainWindow, MainWindow>();

            services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);
            services.AddSingleton<IDispatcher, Dispatcher>();

            services.AddSingleton<IPageViewModelCreatorService, PageViewModelCreatorService>();
            services.AddSingleton<IPageViewModelGetterService, PageViewModelCreatorService.PageViewModelGetterService>();
            services.AddSingleton<IPageFactory, PageFactory>();

            services.AddFeaturesFormPage();
            services.AddFeaturesMainPage();
            services.AddFeaturesNavPage<NavigationViewSelectionChangedEventArgsToNavigationArgsMap>();
            services.AddFeaturesNoNavPage();
            services.AddFeaturesSettingsPage();
            services.AddFeaturesWelcomePage();

            return services.BuildServiceProvider();
        }
    }
}
