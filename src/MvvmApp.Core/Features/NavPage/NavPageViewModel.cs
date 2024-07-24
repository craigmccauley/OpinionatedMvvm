using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;
using System.Collections.ObjectModel;

namespace MvvmApp.Core.Features.NavPage;
public partial class NavPageViewModel : ObservableObject, IPageViewModel
{
    //Need to use object as with the two way binding, the selected item can be set to the "Settings" NavigationViewItem.
    [ObservableProperty]
    private object selectedMenuItem;

    [ObservableProperty]
    private IPageViewModel selectedView;
    public ObservableCollection<MenuItem> MenuItems { get; set; }
    public ISelectionChangedCommand SelectionChangedCommand { get; set; }
}