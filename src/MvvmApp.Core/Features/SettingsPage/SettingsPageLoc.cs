using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmApp.Core.Features.SettingsPage;
public partial class SettingsPageLoc: ObservableObject, ILocalizable
{
    [ObservableProperty]
    public partial string SettingsPage_Description { get; set; }
}
