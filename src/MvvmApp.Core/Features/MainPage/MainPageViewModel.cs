using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.MainPage;
public partial class MainPageViewModel : ObservableObject, IPageViewModel
{
    [ObservableProperty]
    private IPageViewModel selectedView;
}
