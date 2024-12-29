using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.WelcomePage;
public partial class WelcomePageLoc : ObservableObject, ILocalizable
{
    [ObservableProperty]
    public partial string WelcomePage_Description { get; set; }
    [ObservableProperty]
    public partial string WelcomePage_NavigateFormPageButton { get; set; }
    [ObservableProperty]
    public partial string WelcomePage_NavigateNoNavButton { get; set; }
}
