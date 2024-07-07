using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;
using System.Windows.Input;

namespace MvvmApp.Core.Features.WelcomePage;
public interface INavigateToNoNavPageCommand : ICommand { }
public class NavigateToNoNavPageCommand(
    IMessenger messenger) 
    : CommandBase, INavigateToNoNavPageCommand
{
    public override void Execute(object parameter)
    {
        messenger.Send(new ChangeMainPageMessage(AppPages.NoNavPage));
    }
}