using CommunityToolkit.Mvvm.Messaging.Messages;
using MvvmApp.Core.Infrastructure.Application;

namespace MvvmApp.Core.Infrastructure.Messages;
public class ChangeNavPageMessage(AppPage destination) : RequestMessage<ChangeNavPageMessageResult>()
{
    public AppPage Destination => destination;
}
public class ChangeNavPageMessageResult() { }