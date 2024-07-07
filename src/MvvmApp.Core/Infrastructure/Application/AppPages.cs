using MvvmApp.Core.Features.FormPage;
using MvvmApp.Core.Features.MainPage;
using MvvmApp.Core.Features.NavPage;
using MvvmApp.Core.Features.NoNavPage;
using MvvmApp.Core.Features.SettingsPage;
using MvvmApp.Core.Features.WelcomePage;
using System;

namespace MvvmApp.Core.Infrastructure.Application;

public record AppPage(Type ViewModelType);
public static class AppPages
{
    public static AppPage MainPage = new(typeof(MainPageViewModel));
    public static AppPage NoNavPage = new(typeof(NoNavPageViewModel));
    public static AppPage NavPage = new(typeof(NavPageViewModel));
    public static AppPage WelcomePage = new(typeof(WelcomePageViewModel));
    public static AppPage FormPage = new(typeof(FormPageViewModel));
    public static AppPage SettingsPage = new(typeof(SettingsPageViewModel));

    public static AppPage[] All =
    [
        MainPage,
        NoNavPage,
        NavPage,
        WelcomePage,
        FormPage,
        SettingsPage,
    ];
}
