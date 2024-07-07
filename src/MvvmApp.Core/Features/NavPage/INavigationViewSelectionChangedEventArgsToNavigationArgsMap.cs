using MvvmApp.Core.Features.NavPage;

namespace MvvmApp.Features.NavPage;
public interface INavigationViewSelectionChangedEventArgsToNavigationArgsMap
{
    NavigationArgs Map(object src);
}