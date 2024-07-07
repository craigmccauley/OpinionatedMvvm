using System;
using System.Threading.Tasks;

namespace MvvmApp.Core.Infrastructure.Common;
public abstract class CommandAsyncBase : CommandBase
{
    public event EventHandler ExecuteCompleted;
    protected abstract Task ExecuteAsync(object parameter);
    public override async void Execute(object parameter)
    {
        await ExecuteAsync(parameter);
        ExecuteCompleted?.Invoke(this, EventArgs.Empty);
    }
}
