using Microsoft.UI.Xaml.Controls;

using MilkyLabs.Quotes.ViewModels;

namespace MilkyLabs.Quotes.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
