// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace UnoFlipViewDataContextIssue;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using UnoFlipViewDataContextIssue.Controls;
using Vssl.UnoFlipViewDataContextIssue.ViewModels;

/// <summary>
/// The code behind the main page
/// </summary>
public sealed partial class MainPage : Page
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainPage"/> class
    /// </summary>
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = new MainViewModel();
    }

    /// <summary>
    /// The event handler for the button tap that displays the side panel
    /// </summary>
    /// <param name="sender">The sender</param>
    /// <param name="e">The event args</param>
    private void Button_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
    {
        this.sidePanel.Visibility = Visibility.Visible;
    }
}
