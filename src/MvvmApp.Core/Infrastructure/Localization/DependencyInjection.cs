using Microsoft.Extensions.DependencyInjection;

namespace MvvmApp.Core.Infrastructure.Localization;
public static class DependencyInjection
{
    public static void AddInfrastructureLocalization(this IServiceCollection services)
    {
        services.AddSingleton<ILocalizeServiceFactory, LocalizeServiceFactory>();
    }
}
