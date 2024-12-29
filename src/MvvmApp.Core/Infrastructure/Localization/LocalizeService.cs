using CommunityToolkit.Mvvm.Messaging;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Messages;
using System.Globalization;

namespace MvvmApp.Core.Infrastructure.Localization;

public interface ILocalizeService<T> where T : class, ILocalizable, new()
{
    void SetupLocalization<TPageViewModel>(TPageViewModel viewModel) where TPageViewModel : class, IPageViewModel<T>;
}

public class LocalizeService<T> : ILocalizeService<T> where T : class, ILocalizable, new()
{
    public void SetupLocalization<TPageViewModel>(TPageViewModel viewModel) where TPageViewModel : class, IPageViewModel<T>
    {
        viewModel.Loc = Localize();
    }

    private T Localize()
    {
        // Create an instance of the localization DTO
        var localization = new T();

        // Get the type of the DTO and iterate through its properties
        var properties = typeof(T).GetProperties();

        foreach (var property in properties)
        {
            // Assume the property name matches the resource key
            var key = property.Name;

            // Fetch the localized string from the resources
            var value = Resources.ResourceManager.GetString(key, CultureInfo.CurrentUICulture);

            if (value != null)
            {
                // Assign the localized string to the property
                property.SetValue(localization, value);
            }
        }

        return localization;
    }
}
