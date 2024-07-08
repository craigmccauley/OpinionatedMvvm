using Microsoft.Extensions.DependencyInjection;
using Microsoft.Windows.AppLifecycle;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Infrastructure.Application;
using System;
using System.Threading.Tasks;

namespace MvvmApp.WinUI.Infrastructure.Application;

internal class ApplicationService
{
    private readonly IServiceProvider serviceProvider = ApplicationSetup.BuildServiceProvider();
    private bool isInitialized = false;

    internal void Initialize()
    {
        _ = new App();

        var pageViewModelCreatorService = serviceProvider.GetService<IPageViewModelCreatorService>();
        var pageViewModelGetterService = serviceProvider.GetService<IPageViewModelGetterService>();
        pageViewModelGetterService.Initialize(pageViewModelCreatorService);

        var mainWindow = serviceProvider.GetService<IMainWindow>();

        isInitialized = true;
    }

    internal async Task OnApplicationActivated(object sender, AppActivationArguments args)
    {
        if (!isInitialized)
        {
            throw new Exception("Application not Initialized");
        }

        var dispatcher = serviceProvider.GetService<IDispatcher>();
        var mainWindow = serviceProvider.GetService<IMainWindow>();
        var pageViewModelGetterService = serviceProvider.GetService<IPageViewModelGetterService>();
        var mainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel;
        var navPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.NavPage) as NavPageViewModel;

        await dispatcher.RunAsync(() =>
        {
            mainPageViewModel.SelectedView = navPageViewModel;
            mainWindow.Activate();
        });

        //var previousExecutionState = sender == null ? ApplicationExecutionStates.NotRunning : ApplicationExecutionStates.Running;
        //var activationArgsString = ((LaunchActivatedEventArgs)args.Data).Arguments;
        //var activationService = serviceProvider.GetService<IActivationService>();
        //await activationService.Activate(args, previousExecutionState);
    }
}