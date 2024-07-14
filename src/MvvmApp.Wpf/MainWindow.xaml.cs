using MvvmApp.Core.Features.MainPage;
using MvvmApp.Wpf.Infrastructure.Application;
using System.Windows;

namespace MvvmApp.Wpf;
public partial class MainWindow : Window, IMainWindow
{
    public MainPageViewModel MainPageViewModel { get; set; }
    public MainWindow()
    {
        InitializeComponent();
    }
}