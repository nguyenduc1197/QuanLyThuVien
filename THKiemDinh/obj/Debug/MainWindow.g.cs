﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC68CEE4F46C93BBDD447FA6F8167D52E794EF65"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_HomePage;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PhieuMuon;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PhieuTra;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_TimKiem;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThoat;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BaoCaoNgay;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BaoCaoMuonTra;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BaoCaoSach;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label temp;
        
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
            System.Uri resourceLocater = new System.Uri("/THKiemDinh;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.btn_HomePage = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btn_PhieuMuon = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.btn_PhieuMuon.Click += new System.Windows.RoutedEventHandler(this.Btn_PhieuMuon_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_PhieuTra = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.btn_PhieuTra.Click += new System.Windows.RoutedEventHandler(this.Btn_PhieuTra_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_TimKiem = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\MainWindow.xaml"
            this.btn_TimKiem.Click += new System.Windows.RoutedEventHandler(this.Btn_TimKiem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnThoat = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.btnThoat.Click += new System.Windows.RoutedEventHandler(this.BtnThoat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_BaoCaoNgay = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.btn_BaoCaoNgay.Click += new System.Windows.RoutedEventHandler(this.Btn_BaoCaoNgay_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_BaoCaoMuonTra = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\MainWindow.xaml"
            this.btn_BaoCaoMuonTra.Click += new System.Windows.RoutedEventHandler(this.Btn_BaoCaoMuonTra_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_BaoCaoSach = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\MainWindow.xaml"
            this.btn_BaoCaoSach.Click += new System.Windows.RoutedEventHandler(this.Btn_BaoCaoSach_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.temp = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

