using Microsoft.Extensions.DependencyInjection;
using MvvmApp.Core.Infrastructure.Application;
using MvvmApp.Uwp.Infrastructure.Application;
using MvvmApp.Uwp.Pages;
using System;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace MvvmApp.Uwp
{
    sealed partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            this.InitializeComponent();
            serviceProvider = ApplicationSetup.BuildServiceProvider();
            this.Suspending += serviceProvider.GetService<ISuspendingService>().OnSuspending;
        }
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            serviceProvider.GetService<ILaunchedService>().OnLaunched(this, e);
        }
    }
}
