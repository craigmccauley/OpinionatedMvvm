using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.WelcomePage;

public partial class WelcomePageViewModel : ObservableObject, IPageViewModel
{
    public INavigateToNoNavPageCommand NavigateToNoNavPageCommand { get; set; }
    public INavigateToFormPageCommand NavigateToFormPageCommand { get; set; }
}