using Microsoft.UI.Xaml.Controls;
using MilkyLabs.Quotes.App.ViewModels;

namespace MilkyLabs.Quotes.App.Views;

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
