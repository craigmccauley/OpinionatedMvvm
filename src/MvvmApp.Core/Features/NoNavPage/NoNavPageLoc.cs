using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Features.NoNavPage;
public partial class NoNavPageLoc : ObservableObject, ILocalizable
{
    [ObservableProperty]
    public partial string NoNavPage_BackButton { get; set; }
    [ObservableProperty]
    public partial string NoNavPage_BodyText { get; set; }
}
