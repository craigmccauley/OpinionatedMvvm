using System;
using System.Threading.Tasks;

namespace MvvmApp.Core.Infrastructure.Application;
public interface IDispatcher
{
    Task RunAsync(Action action);
}
