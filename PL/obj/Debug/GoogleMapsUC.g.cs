﻿#pragma checksum "..\..\GoogleMapsUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E5C23B0DA9D3E1277706B8DCB9E3169F1DFDF7F5A5501A83AAD8EFF9B68AF95"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Maps.MapControl.WPF;
using PL;
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


namespace PL {
    
    
    /// <summary>
    /// GoogleMapsUC
    /// </summary>
    public partial class GoogleMapsUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\GoogleMapsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PL.GoogleMapsUC GoogleMapsUC1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GoogleMapsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map MainMap;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GoogleMapsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MapModeButten;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\GoogleMapsUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatlliteModeButten;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/googlemapsuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GoogleMapsUC.xaml"
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
            this.GoogleMapsUC1 = ((PL.GoogleMapsUC)(target));
            return;
            case 2:
            this.MainMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 3:
            this.MapModeButten = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\GoogleMapsUC.xaml"
            this.MapModeButten.Click += new System.Windows.RoutedEventHandler(this.MapModeButten_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StatlliteModeButten = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\GoogleMapsUC.xaml"
            this.StatlliteModeButten.Click += new System.Windows.RoutedEventHandler(this.StatlliteModeButten_Click);
            
            #line default
            #line hidden
            
            #line 23 "..\..\GoogleMapsUC.xaml"
            this.StatlliteModeButten.MouseEnter += new System.Windows.Input.MouseEventHandler(this.StatlliteModeButten_MouseEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

