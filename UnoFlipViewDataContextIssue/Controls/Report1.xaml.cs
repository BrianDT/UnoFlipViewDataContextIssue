// <copyright file="Report1.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
namespace UnoFlipViewDataContextIssue.Controls;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Vssl.UnoFlipViewDataContextIssue.ViewModelInterfaces;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

/// <summary>
/// The code behind the first report view
/// </summary>
public sealed partial class Report1 : UserControl
{
    private IReportData? lastViewModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="Report1"/> class
    /// </summary>
    public Report1()
    {
        this.InitializeComponent();
        this.DataContextChanged += this.OnDataContextChanged;
        this.Loading += this.OnLoading;
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
            if (this.VM != null)
            {
                this.lastViewModel = this.VM;
            }
        }
        else
        {
            this.dataContextType.Text = "null";
        }
    }

    private void OnLoading(object? sender, object e)
    {
        if (this.lastViewModel != null && this.VM == null)
        {
            this.DataContext = this.lastViewModel;
            this.Rebind();
        }
    }

    /// <summary>
    /// Rebind the compiled bindings
    /// </summary>
    private void Rebind()
    {
        if (this.Bindings != null)
        {
            this.Bindings.Update();
        }
    }
}
