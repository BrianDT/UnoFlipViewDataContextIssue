// <copyright file="IReportData.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace Vssl.UnoFlipViewDataContextIssue.ViewModelInterfaces;

using Vssl.Samples.FrameworkInterfaces;

/// <summary>
/// The view model for the side panel
/// </summary>
public interface IReportData : IBindableBase
{
    /// <summary>
    /// Gets a data entry
    /// </summary>
    string Data { get; }
}
