using MvvmApp.Core.Infrastructure.Application;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace MvvmApp.Uwp.Infrastructure.Application;
public class Dispatcher : IDispatcher
{
    public async Task RunAsync(Action action)
    {
        await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action());
    }
}
