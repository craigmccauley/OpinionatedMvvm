using System;

namespace MvvmApp.Core.Infrastructure.Common;
public interface IPageViewModelFactory
{
    Type ViewModelType { get; }
    IPageViewModel Invoke();
}
public interface IPageViewModelFactory<TPageViewModel> : IPageViewModelFactory where TPageViewModel : IPageViewModel
{
    new TPageViewModel Invoke();
}
