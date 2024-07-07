using MvvmApp.Core.Infrastructure.Application;

namespace MvvmApp.Core.Features.NavPage;
public class NavigationArgs
{
    public AppPage SelectedPage { get; set; }
    public NavPageViewModel NavPageViewModel { get; set; }
}
