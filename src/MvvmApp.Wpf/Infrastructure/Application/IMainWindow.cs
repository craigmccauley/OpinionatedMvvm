using MvvmApp.Core.Features.MainPage;

namespace MvvmApp.Wpf.Infrastructure.Application;
public interface IMainWindow
{
    MainPageViewModel MainPageViewModel { get; }
    bool Activate();
}
