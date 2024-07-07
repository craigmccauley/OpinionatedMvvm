using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Uwp.Pages;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MvvmApp.Uwp.Infrastructure.Application;

public interface ILaunchedService
{
    void OnLaunched(object sender, LaunchActivatedEventArgs e);
}

public class LaunchedService(
    IPageViewModelGetterService pageViewModelGetterService,
    IPageViewModelCreatorService pageViewModelCreatorService,
    INavigationFailedService navigationFailedService) : ILaunchedService
{
    public void OnLaunched(object sender, LaunchActivatedEventArgs e)
    {
        // Do not repeat app initialization when the Window already has content,
        // just ensure that the window is active
        if (Window.Current.Content is not Frame rootFrame)
        {
            // Create a Frame to act as the navigation context and navigate to the first page
            rootFrame = new Frame();

            rootFrame.NavigationFailed += navigationFailedService.OnNavigationFailed;

            if (e.PreviousExecutionState == Windows.ApplicationModel.Activation.ApplicationExecutionState.Terminated)
            {
                //TODO: Load state from previously suspended application
            }

            // Place the frame in the current Window
            Window.Current.Content = rootFrame;
        }

        if (e.PrelaunchActivated == false)
        {
            pageViewModelGetterService.Initialize(pageViewModelCreatorService);
            if (rootFrame.Content != null)
            {
                return;
            }

            var mainPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.MainPage) as MainPageViewModel;
            var navPageViewModel = pageViewModelGetterService.GetPageViewModel(AppPages.NavPage) as NavPageViewModel;
            navPageViewModel.SelectedMenuItem = navPageViewModel.MenuItems[0];
            navPageViewModel.SelectedView = pageViewModelGetterService.GetPageViewModel(navPageViewModel.MenuItems[0].NavDestination);
            mainPageViewModel.SelectedView = navPageViewModel;
            rootFrame.DataContext = mainPageViewModel;
            rootFrame.Navigate(typeof(MainPage), e.Arguments);
            Window.Current.Activate();
        }
    }
}
