using MvvmApp.Core.Infrastructure.Common;
using System;
using System.Collections.Generic;

namespace MvvmApp.Core.Infrastructure.Application;

public interface IPageViewModelCreatorService
{
}
public interface IPageViewModelGetterService
{
    void Initialize(IPageViewModelCreatorService pageViewModelCreatorService);
    IPageViewModel GetPageViewModel(AppPage page);
}

public class PageViewModelCreatorService(IPageFactory pageFactory) : IPageViewModelCreatorService
{
    private Dictionary<AppPage, IPageViewModel> pages = pageFactory?.CreateIndex();

    private IPageViewModel GetPageViewModel(AppPage page)
    {
        if (!pages.TryGetValue(page, out var pageViewModel))
        {
            throw new Exception($"PageViewModel \"{page.ViewModelType.Name}\" not found. " +
                $"Check that you have created a factory for it and that the factory is being injected as a IPageViewModelFactory.");
        }
        return pageViewModel;
    }

    /// <summary>
    /// Initializer to avoid circular references.
    /// </summary>
    public class PageViewModelGetterService : IPageViewModelGetterService
    {
        private PageViewModelCreatorService pageViewModelCreatorService;
        public void Initialize(IPageViewModelCreatorService pageViewModelCreatorService)
        {
            this.pageViewModelCreatorService = ((PageViewModelCreatorService)pageViewModelCreatorService);
        }

        public IPageViewModel GetPageViewModel(AppPage page)
        {
            if(pageViewModelCreatorService == null)
            {
                throw new Exception("PageViewModelGetterService not initialized. Call Initialize() before using it.");
            }
            return pageViewModelCreatorService.GetPageViewModel(page);
        }
    }
}