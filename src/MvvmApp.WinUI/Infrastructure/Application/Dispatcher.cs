using CommunityToolkit.WinUI;
using Microsoft.UI.Dispatching;
using MvvmApp.Core.Infrastructure.Application;
using System;
using System.Threading.Tasks;

namespace MvvmApp.WinUI.Infrastructure.Application;
public class Dispatcher : IDispatcher
{
    public async Task RunAsync(Action action)
    {
        await DispatcherQueue.GetForCurrentThread().EnqueueAsync(action);
    }
}
