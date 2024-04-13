using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Web.WebView2.Core;
using MilkyLabs.Quotes.Contracts.Services;
using MilkyLabs.Quotes.Views;

namespace MilkyLabs.Quotes.ViewModels;

public partial class ShellViewModel : ObservableRecipient
{
    [ObservableProperty]
    private bool isBackEnabled;

    [ObservableProperty]
    private object? selected;

    public INavigationService NavigationService
    {
        get;
    }

    public INavigationViewService NavigationViewService
    {
        get;
    }

    public ShellViewModel(INavigationService navigationService, INavigationViewService navigationViewService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;
        NavigationViewService = navigationViewService;
    }

    private void OnNavigated(object sender, NavigationEventArgs e)
    {
        IsBackEnabled = NavigationService.CanGoBack;
        var selectedItem = NavigationViewService.GetSelectedItem(e.SourcePageType);
        if (selectedItem != null)
        {
            Selected = selectedItem;
        }
    }
    public static FontIcon QuoteDefaultIcon => new FontIcon { Glyph = "&#xe7c3;" };
    public IEnumerable<NavigationViewItem> MenuItems => new NavigationViewItem[]
    {
        new (){Content = "Quote 1", Icon = QuoteDefaultIcon},
        new (){Content = "Quote 2", Icon = QuoteDefaultIcon},
        new (){Content = "Quote 3", Icon = QuoteDefaultIcon},
        new (){Content = "Very long quote with many letters in it", Icon = QuoteDefaultIcon},
    };
}
