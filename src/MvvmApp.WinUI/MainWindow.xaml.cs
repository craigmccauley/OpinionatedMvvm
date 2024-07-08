using Microsoft.UI.Xaml;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.WinUI.Infrastructure.Application;

namespace MvvmApp.WinUI;

public sealed partial class MainWindow : Window, IMainWindow
{
    public MainPageViewModel MainPageViewModel { get; }
    public MainWindow(
        IPageViewModelGetterService pageViewModelGetterService)
    {
        this.InitializeComponent();
        MainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel;
    }
}
