// <copyright file="Report3.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
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
/// The code behind the third report view with workaround
/// </summary>
public sealed partial class Report3 : UserControl
{
    /// <summary>
    /// Using a DependencyProperty as the backing store for VMO.  This enables animation, styling, binding, etc...
    /// </summary>
    public static readonly DependencyProperty VMOProperty =
        DependencyProperty.Register("VMO", typeof(object), typeof(Report3), new PropertyMetadata(null, Report3.OnVMOChanged));

    private IReportData? lastViewModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="Report3"/> class
    /// </summary>
    public Report3()
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
    /// Gets or sets a view model object
    /// </summary>
    public object VMO
    {
        get { return (object)this.GetValue(VMOProperty); }
        set { this.SetValue(VMOProperty, value); }
    }

    /// <summary>
    /// Called when there is a change to the outline foreground colour
    /// </summary>
    /// <param name="d">The dependency object</param>
    /// <param name="e">The event args</param>
    private static void OnVMOChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        Report3? control = d as Report3;
        if (control != null && e.NewValue != null && control.VM == null)
        {
            var newVM = e.NewValue as IReportData;
            if (newVM != null)
            {
                control.DataContext = newVM;
            }
        }

        if (control != null && control.VM != null)
        {
            control.lastViewModel = control.VM;
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
