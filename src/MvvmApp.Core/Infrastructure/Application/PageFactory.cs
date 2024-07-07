using MvvmApp.Core.Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;

namespace MvvmApp.Core.Infrastructure.Application;

public interface IPageFactory
{
    Dictionary<AppPage, IPageViewModel> CreateIndex();
}

public class PageFactory(IEnumerable<IPageViewModelFactory> factories) : IPageFactory
{
    private readonly List<IPageViewModelFactory> factoryList = factories.ToList();
    public Dictionary<AppPage, IPageViewModel> CreateIndex() => AppPages.All.ToDictionary(page => page, page =>
    {
        var fac = factoryList.Single(f => f.ViewModelType == page.ViewModelType);
        return fac.Invoke();
    });
}
