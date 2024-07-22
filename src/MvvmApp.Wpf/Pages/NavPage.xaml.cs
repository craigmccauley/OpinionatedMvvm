using MvvmApp.Core.Features.NavPage;
using MvvmApp.Wpf.Infrastructure.Converters;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;

//Sigh, MvvmApp.Wpf and Wpf.Ui namespaces get confused in the generated file.
namespace MvvmAppWpf.Pages;
public partial class NavPage : UserControl
{
    public NavPage()
    {
        InitializeComponent();
    }

    private void NavigationView_Loaded(object sender, RoutedEventArgs e)
    {
        //var navigationView = (NavigationView)sender;
        //var vm = (NavPageViewModel)DataContext;

        //navigationView.Navigate(MenuItemConverter.MapToPage(vm.SelectedMenuItem.NavDestination), vm.SelectedView);
    }
}
