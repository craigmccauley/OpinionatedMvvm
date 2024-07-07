using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.FormPage;

public class FormPageViewModelFactory : PageViewModelFactoryBase<FormPageViewModel>
{
    public override FormPageViewModel Invoke() => new();
}