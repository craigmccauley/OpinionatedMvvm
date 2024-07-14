using MvvmApp.Core.Infrastructure.Application;

namespace MvvmApp.Wpf.Infrastructure.Application;
public class Dispatcher : IDispatcher
{
    public async Task RunAsync(Action action)
    {
        await System.Windows.Application.Current.Dispatcher.InvokeAsync(action);
    }
}
