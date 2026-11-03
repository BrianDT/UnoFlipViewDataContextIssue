// <copyright file="MainActivity.Android.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>

namespace UnoFlipViewDataContextIssue.Droid;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;

/// <summary>
/// The main Android activity.
/// </summary>
[Activity(
    MainLauncher = true,
    ConfigurationChanges = global::Uno.UI.ActivityHelper.AllConfigChanges,
    WindowSoftInputMode = SoftInput.AdjustNothing | SoftInput.StateHidden,
    Exported = true)]
public class MainActivity : Microsoft.UI.Xaml.ApplicationActivity
{
    /// <summary>
    /// Called on activity creation
    /// </summary>
    /// <param name="savedInstanceState">An optional data bundle</param>
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        global::AndroidX.Core.SplashScreen.SplashScreen.InstallSplashScreen(this);

        base.OnCreate(savedInstanceState);
    }
}
