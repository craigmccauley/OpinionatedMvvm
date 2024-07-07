using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.FormPage;
public static class DependencyInjection
{
    public static void AddFeaturesFormPage(this IServiceCollection services)
    {
        services.AddSingleton<IPageViewModelFactory, FormPageViewModelFactory>();
    }
}
