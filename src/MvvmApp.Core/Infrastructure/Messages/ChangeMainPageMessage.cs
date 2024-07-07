using CommunityToolkit.Mvvm.Messaging.Messages;
using MvvmApp.Core.Infrastructure.Application;

namespace MvvmApp.Core.Infrastructure.Messages;
public class ChangeMainPageMessage(AppPage destination) : RequestMessage<ChangeMainPageMessageResult>
{
    public AppPage Destination => destination;
}

public class ChangeMainPageMessageResult() { }