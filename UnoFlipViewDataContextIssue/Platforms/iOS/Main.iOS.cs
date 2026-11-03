// <copyright file="Main.iOS.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace UnoFlipViewDataContextIssue.iOS;

using UIKit;
using Uno.UI.Hosting;

/// <summary>
/// Main program
/// </summary>
public class EntryPoint
{
    /// <summary>
    /// This is the main entry point of the application.
    /// </summary>
    /// <param name="args">Any optional command line arguments</param>
    public static void Main(string[] args)
    {
        App.InitializeLogging();

        var host = UnoPlatformHostBuilder.Create()
            .App(() => new App())
            .UseAppleUIKit()
            .Build();

        host.Run();
    }
}
