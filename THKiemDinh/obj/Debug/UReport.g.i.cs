﻿#pragma checksum "..\..\UReport.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753B91070D8919EFDBC5C951684A237608CA231E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using THKiemDinh;


namespace THKiemDinh {
    
    
    /// <summary>
    /// UReport
    /// </summary>
    public partial class UReport : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\UReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butLoc_bcngay1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butLoc_bcmuontra1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butLoc_bcsach1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid main_report;
        
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
            System.Uri resourceLocater = new System.Uri("/THKiemDinh;component/ureport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UReport.xaml"
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
            this.butLoc_bcngay1 = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\UReport.xaml"
            this.butLoc_bcngay1.Click += new System.Windows.RoutedEventHandler(this.ButLoc_bcngay_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butLoc_bcmuontra1 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\UReport.xaml"
            this.butLoc_bcmuontra1.Click += new System.Windows.RoutedEventHandler(this.ButLoc_bcmuontra_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.butLoc_bcsach1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\UReport.xaml"
            this.butLoc_bcsach1.Click += new System.Windows.RoutedEventHandler(this.ButLoc_bcsach_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.main_report = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
