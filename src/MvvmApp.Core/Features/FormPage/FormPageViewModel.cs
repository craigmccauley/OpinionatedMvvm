using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.FormPage;
public partial class FormPageViewModel : ObservableObject, IPageViewModel
{
    [ObservableProperty]
    private string title = "Form Page";
}
