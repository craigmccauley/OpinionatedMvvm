using CommunityToolkit.Mvvm.ComponentModel;
using MvvmApp.Core.Infrastructure.Common;

namespace MvvmApp.Core.Features.FormPage;
public partial class FormPageViewModel : ObservableObject, IPageViewModel<FormPageLoc>
{
    public FormPageLoc Loc { get; set; }
}
