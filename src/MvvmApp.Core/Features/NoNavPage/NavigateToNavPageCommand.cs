using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;
using System.Windows.Input;

namespace MvvmApp.Core.Features.NoNavPage;
public interface INavigateToNavPageCommand : ICommand { }
public class NavigateToNavPageCommand(IMessenger messenger) : CommandBase, INavigateToNavPageCommand
{
    public override void Execute(object parameter)
    {
        messenger.Send(new ChangeMainPageMessage(AppPages.NavPage));
    }
}