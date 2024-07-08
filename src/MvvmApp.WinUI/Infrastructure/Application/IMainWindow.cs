using MvvmApp.Core.Features.MainPage;

namespace MvvmApp.WinUI.Infrastructure.Application;
public interface IMainWindow
{
    MainPageViewModel MainPageViewModel { get; }
    void Activate();
}
