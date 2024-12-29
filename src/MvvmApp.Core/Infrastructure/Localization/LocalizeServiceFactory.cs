using CommunityToolkit.Mvvm.Messaging;

namespace MvvmApp.Core.Infrastructure.Localization;

public interface ILocalizeServiceFactory
{
    ILocalizeService<T> Invoke<T>() where T : class, ILocalizable, new();
}

public class LocalizeServiceFactory : ILocalizeServiceFactory
{
    public ILocalizeService<T> Invoke<T>() where T : class, ILocalizable, new()
    {
        return new LocalizeService<T>();
    }
}
