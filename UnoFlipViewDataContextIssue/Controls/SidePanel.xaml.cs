// <copyright file="SidePanel.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2026 All rights reserved</copyright>
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
using Vssl.UnoFlipViewDataContextIssue.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

/// <summary>
/// The code behind the side panel that contains the FlipView
/// </summary>
public sealed partial class SidePanel : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SidePanel"/> class
    /// </summary>
    public SidePanel()
    {
        this.InitializeComponent();
        this.DataContext = new ReportData();
    }
}
