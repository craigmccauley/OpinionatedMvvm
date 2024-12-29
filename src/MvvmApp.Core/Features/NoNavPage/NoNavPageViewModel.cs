using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.NoNavPage;
public partial class NoNavPageViewModel : ObservableObject, IPageViewModel<NoNavPageLoc>
{
    [ObservableProperty]
    public partial NoNavPageLoc Loc { get; set; }
    public INavigateToNavPageCommand NavigateToNavPageCommand { get; set; }
}