using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;

namespace MvvmApp.Core.Features.MainPage;
public class MainPageViewModelFactory(
    IMessenger messenger,
    IMainPageNavigationService mainPageNavigationService) 
    : PageViewModelFactoryBase<MainPageViewModel>
{
    public override MainPageViewModel Invoke()
    {
        var vm = new MainPageViewModel();

        messenger.Register<MainPageViewModel, ChangeMainPageMessage>(vm, mainPageNavigationService.OnNavigationMessageReceived);

        return vm;
    }
}
