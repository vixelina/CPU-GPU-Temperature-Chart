﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E665D83674CB6BA7C7C9BC1452FF2E8950CF8269"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace YourWPFProject {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart chart;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid legendGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid cpuTempGrid;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gpuTempGrid;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid warningCpuGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid warningGpuGrid;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid aboutBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/temperature_graph;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.chart = ((LiveCharts.Wpf.CartesianChart)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.chart.Loaded += new System.Windows.RoutedEventHandler(this.chart_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.legendGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.legendGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.legendGrid.MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.legendGrid.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowCpuTemperatures);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowGpuTemperatures);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cpuTempGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.cpuTempGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 60 "..\..\MainWindow.xaml"
            this.cpuTempGrid.MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 61 "..\..\MainWindow.xaml"
            this.cpuTempGrid.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.HideCpuTemperatures);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gpuTempGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.gpuTempGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 80 "..\..\MainWindow.xaml"
            this.gpuTempGrid.MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 81 "..\..\MainWindow.xaml"
            this.gpuTempGrid.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 86 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.HideGpuTemperatures);
            
            #line default
            #line hidden
            return;
            case 9:
            this.warningCpuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.warningGpuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            
            #line 114 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowAboutBox);
            
            #line default
            #line hidden
            return;
            case 12:
            this.aboutBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            
            #line 123 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseAboutBox);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

