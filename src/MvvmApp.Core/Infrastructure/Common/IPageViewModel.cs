using MvvmApp.Core.Infrastructure.Localization;

namespace MvvmApp.Core.Infrastructure.Common;
public interface IPageViewModel { }
public interface IPageViewModel<T> : IPageViewModel where T : class, ILocalizable, new()
{
    T Loc { get; set; }
}