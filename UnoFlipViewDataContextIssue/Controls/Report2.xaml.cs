// <copyright file="Report2.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace UnoFlipViewDataContextIssue.Controls;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Vssl.UnoFlipViewDataContextIssue.ViewModelInterfaces;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

/// <summary>
/// The code behind the second report view with workaround
/// </summary>
public sealed partial class Report2 : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Report2"/> class
    /// </summary>
    public Report2()
    {
        this.InitializeComponent();
        this.DataContextChanged += this.OnDataContextChanged;
        this.dataContextType.Text = "unset";
    }

    /// <summary>
    /// Gets the interface to the view model used for compile time binding
    /// </summary>
    public IReportData? VM
    {
        get
        {
            return this.DataContext as IReportData;
        }
    }

    /// <summary>
    /// The event handler for data contect change
    /// </summary>
    /// <param name="sender">The sender</param>
    /// <param name="e">The event args</param>
    private void OnDataContextChanged(object? sender, DataContextChangedEventArgs e)
    {
        if (this.DataContext != null)
        {
            this.dataContextType.Text = this.DataContext.GetType().ToString();
        }
        else
        {
            this.dataContextType.Text = "null";
        }
    }
}
