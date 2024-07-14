using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Infrastructure.Application;
using System.Windows;

namespace MvvmApp.Wpf.Infrastructure.Application;

internal class ApplicationService
{
    private readonly IServiceProvider serviceProvider = ApplicationSetup.BuildServiceProvider();
    private bool isInitialized = false;

    internal void Initialize()
    {
        var app = new App();
        app.InitializeComponent();
        app.Startup += OnApplicationActivated;

        var pageViewModelCreatorService = serviceProvider.GetService<IPageViewModelCreatorService>();
        var pageViewModelGetterService = serviceProvider.GetService<IPageViewModelGetterService>();
        pageViewModelGetterService.Initialize(pageViewModelCreatorService);


        var mainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel;
        var navPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.NavPage) as NavPageViewModel;
        mainPageViewModel.SelectedView = navPageViewModel;

        app.MainWindow = new MainWindow
        {
            MainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel,
        };
        isInitialized = true;

        app.Run();
    }


    internal async void OnApplicationActivated(object sender, StartupEventArgs args)
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

        //mainPageViewModel.SelectedView = navPageViewModel;
        mainWindow.Activate();
        //await dispatcher.RunAsync(() =>
        //{
        //    mainPageViewModel.SelectedView = navPageViewModel;
        //    mainWindow.Activate();
        //});

        //var previousExecutionState = sender == null ? ApplicationExecutionStates.NotRunning : ApplicationExecutionStates.Running;
        //var activationArgsString = ((LaunchActivatedEventArgs)args.Data).Arguments;
        //var activationService = serviceProvider.GetService<IActivationService>();
        //await activationService.Activate(args, previousExecutionState);
    }
}