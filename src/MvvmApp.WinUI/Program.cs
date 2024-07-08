using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.Windows.AppLifecycle;
using MvvmApp.WinUI.Infrastructure.Application;
using System;
using System.Threading;
using WinRT;

namespace MvvmApp.WinUI;

internal class Program
{
    [STAThread]
    static void Main(string[] _)
    {
        ComWrappersSupport.InitializeComWrappers();
        var args = AppInstance.GetCurrent().GetActivatedEventArgs();
        var keyInstance = AppInstance.FindOrRegisterForKey("MvvmApp");

        if (!keyInstance.IsCurrent)
        {
            keyInstance.RedirectActivationToAsync(args).GetAwaiter().GetResult();
            return;
        }

        var applicationService = new ApplicationService();

        keyInstance.Activated += async (sender, e) =>
        {
            await applicationService.OnApplicationActivated(sender, e);
        };

        Application.Start(_ =>
        {
            var context = new DispatcherQueueSynchronizationContext(DispatcherQueue.GetForCurrentThread());
            SynchronizationContext.SetSynchronizationContext(context);
            applicationService.Initialize();
            applicationService.OnApplicationActivated(null, args).GetAwaiter().GetResult();
        });
    }
}
