using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Features.NavPage;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmApp.Core.Features.NavPage;
public interface ISelectionChangedCommand : ICommand { }
public class SelectionChangedCommand(
    IPageViewModelGetterService pageViewModelGetterService,
    IDispatcher dispatcher,
    INavigationViewSelectionChangedEventArgsToNavigationArgsMap map)
    : CommandAsyncBase, ISelectionChangedCommand
{
    protected override async Task ExecuteAsync(object parameter)
    {
        var args = map.Map(parameter);
        if (args == null)
        {
            return;
        }
        var destination = pageViewModelGetterService.GetPageViewModel(args.SelectedPage);
        await dispatcher.RunAsync(() =>
        {
            args.NavPageViewModel.SelectedView = destination;
        });
    }
}
