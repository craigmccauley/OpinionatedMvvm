using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;
using MvvmApp.Core.Infrastructure.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmApp.Core.Features.FormPage;
public partial class FormPageLoc : ObservableObject, ILocalizable
{
    [ObservableProperty]
    public partial string FormPage_Description { get; set; }
}
