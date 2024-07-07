using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;
using System.Windows.Input;

namespace MvvmApp.Core.Features.WelcomePage;
public interface INavigateToFormPageCommand : ICommand { }
public class NavigateToFormPageCommand(
    IMessenger messenger) : CommandBase, INavigateToFormPageCommand
{
    public override void Execute(object parameter)
    {
        messenger.Send(new ChangeNavPageMessage(AppPages.FormPage));
    }
}
