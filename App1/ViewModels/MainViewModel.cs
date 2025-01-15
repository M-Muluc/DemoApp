using CommunityToolkit.Mvvm.ComponentModel;

namespace App1.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    [ObservableProperty] private ContentViewModel _contentViewModel;
}