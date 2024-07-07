using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.NoNavPage;
public partial class NoNavPageViewModel : ObservableObject, IPageViewModel
{
    public INavigateToNavPageCommand NavigateToNavPageCommand { get; set; }
}