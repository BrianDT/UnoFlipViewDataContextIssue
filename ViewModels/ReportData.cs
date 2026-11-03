// <copyright file="ReportData.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace Vssl.UnoFlipViewDataContextIssue.ViewModels;

using ViewModelInterfaces;
using Vssl.Samples.Framework.ViewModels;

/// <summary>
/// The view model for the side panel
/// </summary>
public class ReportData : BindableBase, IReportData
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportData"/> class
    /// </summary>
    public ReportData()
    {
        this.Data = "Some bound data value";
    }

    /// <summary>
    /// Gets a data entry
    /// </summary>
    public string Data { get; }

    /// <summary>
    /// Gets a value indicating whether the model has been disposed (abstract)
    /// </summary>
    public override bool IsDisposed => false;
}
