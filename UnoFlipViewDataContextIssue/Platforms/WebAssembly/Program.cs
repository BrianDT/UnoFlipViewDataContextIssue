// <copyright file="Program.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace UnoFlipViewDataContextIssue;

using System.Threading.Tasks;
using Uno.UI.Hosting;

/// <summary>
/// Main program
/// </summary>
public class Program
{
    /// <summary>
    /// This is the main entry point of the application.
    /// </summary>
    /// <param name="args">Any optional command line arguments</param>
    /// <returns>An awaitable task</returns>
    public static async Task Main(string[] args)
    {
        App.InitializeLogging();

        var host = UnoPlatformHostBuilder.Create()
            .App(() => new App())
            .UseWebAssembly()
            .Build();

        await host.RunAsync();
    }
}
