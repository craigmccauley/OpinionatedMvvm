using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Wpf.Infrastructure.Application;

namespace MvvmApp.Wpf;
public class Program
{
    private static readonly IServiceProvider serviceProvider = ApplicationSetup.BuildServiceProvider();
    [STAThread]
    static void Main(string[] _)
    {
        var pageViewModelCreatorService = serviceProvider.GetService<IPageViewModelCreatorService>();
        var pageViewModelGetterService = serviceProvider.GetService<IPageViewModelGetterService>();
        pageViewModelGetterService!.Initialize(pageViewModelCreatorService);

        var app = new App();
        app.InitializeComponent();
        app.Startup += (sender, e) =>
        {
            var mainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel;
            var navPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.NavPage) as NavPageViewModel;

            mainPageViewModel!.SelectedView = navPageViewModel!;


            app.MainWindow = new MainWindow
            {
                DataContext = mainPageViewModel,
            };
            app.MainWindow.Show();
        };
        app.Run();
    }
}
