﻿#pragma checksum "..\..\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "19CDE8C0669639632BC96BE91D940F8501E926A16EF6942830F8C0A96ECEC01C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt1;
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


namespace Projekt1 {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompletedOrders;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextCompletedOrders;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextID;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextPrice;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextOrderTime;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextDetails;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLangPL;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLangEng;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekt1;component/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainControl.xaml"
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
            this.Menu = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MainControl.xaml"
            this.Menu.Click += new System.Windows.RoutedEventHandler(this.ButtonMenuClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextMenu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.CompletedOrders = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainControl.xaml"
            this.CompletedOrders.Click += new System.Windows.RoutedEventHandler(this.ButtonCmpOrdersClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextCompletedOrders = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.MainGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.TextID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TextOrderTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TextDetails = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.ButtonLangPL = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\MainControl.xaml"
            this.ButtonLangPL.Click += new System.Windows.RoutedEventHandler(this.LanguagePLClicked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ButtonLangEng = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\MainControl.xaml"
            this.ButtonLangEng.Click += new System.Windows.RoutedEventHandler(this.LanguageENGClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 63 "..\..\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._BtnDetails);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 79 "..\..\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._BtnComplete);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

